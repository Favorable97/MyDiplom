using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Diplom {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            OpenFile.Filter = "Text files(*.cpp)|*.cpp|All files(*.*)|*.*";
            OpenFile.InitialDirectory = AppDomain.CurrentDomain.RelativeSearchPath;
            //CodeAnalysis.Click += CodeAnalysis_Click;
        }
        //List<string> lstWithNameList; // контейнер, где хранятся имена всех контейнеров C++
        List<string> lstWithTypeIter; // контейнер, где хранятся блоки со всеми циклами C++
        Dictionary<string, int> informationMas;
        string textFile = "";
        string filePath = "";
        /*Выбор файла*/
        private void ToChooseFile_Click(object sender, EventArgs e) {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;

            filePath = OpenFile.FileName;
            ReadFile(ref textFile);
            richTextBox1.Text = textFile;
            statusStrip1.Visible = true;
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = filePath;
        }

        private void ReadFile(ref string text) {
            try {
                using (StreamReader read = new StreamReader(filePath, System.Text.Encoding.Default)) {
                    string line = "";
                    while ((line = read.ReadLine()) != null) {
                        text += line + '\n';
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка чтения из файла: " + ex.Message + "\n" + ex.Source);
            }
        }

        /*
         * Событие кнопки
         * По нажатии анализируется код
         */
        private void CodeAnalysis_Click(object sender, EventArgs e) {
            if (filePath == "") {
                MessageBox.Show("Не выбран файл!");
            } else {
                ParsingClass parsing = new ParsingClass(textFile);
                parsing.ParsingText();
                informationMas = parsing.informationMas;
                lstWithTypeIter = parsing.lstWithTypeIter;
                MyTable.Visible = true;
                MyTable.RowCount = informationMas.Count;
                ToFillTable();
                CalculationWin.Visible = true;
            }
        }

            #region _Grow_to_
            /*
             * size_type _Grow_to(size_type _Count) const
		{	// grow by 50% or at least to _Count
		size_type _Capacity = capacity();

		_Capacity = max_size() - _Capacity / 2 < _Capacity
			? 0 : _Capacity + _Capacity / 2;	// try to grow by 50%
		if (_Capacity < _Count)
			_Capacity = _Count;
		return (_Capacity);
		}
             */
            #endregion

        
        /*
         * Заполнение таблицы начальными значениями
         */
        private void ToFillTable() {
            int index = 0;
            foreach (KeyValuePair<string, int> tmp in informationMas) {
                MyTable.Rows[index].Cells[1].Value = tmp.Key;
                MyTable.Rows[index].Cells[3].Value = tmp.Value;
                index++;
            }
            for (int i = 0; i < informationMas.Count; i++) {
                MyTable.Rows[i].Cells[0].Value = false;
                MyTable.Rows[i].Cells[4].Value = "???";
                MyTable.Rows[i].Cells[2].Value = lstWithTypeIter[i];
                MyTable.Rows[i].Cells[5].Value = ToCalculateDifference(lstWithTypeIter[i]);
            }
        }


        /*Событие checkbox - ов в DataGridView*/
        public double myWin;
        double v, tmpV, resultV;
        int k;
        private void MyTable_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (Convert.ToInt16(MyTable.SelectedCells[0].ColumnIndex) != 0)
                return;
            k = 0;
            MyTable.EndEdit();
            if (k == 1)
                return;
            else {
                k++;
                v = Convert.ToDouble(LimitMemory.Text);
                int index = MyTable.SelectedCells[0].RowIndex;
                if (Convert.ToBoolean(MyTable.CurrentCell.Value) == true) {
                    resultV += 1.5 * Convert.ToInt16(MyTable.Rows[index].Cells[4].Value) * ToDefineType(lstWithTypeIter[index]);
                    MyTable.Rows[index].Cells[6].Value = 1.5 * Convert.ToInt16(MyTable.Rows[index].Cells[4].Value) * ToDefineType(lstWithTypeIter[index]);
                    myWin += Convert.ToInt16(MyTable.Rows[index].Cells[4].Value) * ToCalculateDifference(lstWithTypeIter[index]);
                    if (resultV <= v) {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
                    }
                    else {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "Ограничение не выполняется, " + " затрачено: " + resultV + " байт";
                    }
                    return;
                }
                else {
                    resultV -= 1.5 * Convert.ToInt32(MyTable.Rows[index].Cells[4].Value) * ToDefineType(lstWithTypeIter[index]);
                    myWin -= Convert.ToInt32(MyTable.Rows[index].Cells[4].Value) * ToCalculateDifference(lstWithTypeIter[index]);
                    MyTable.Rows[index].Cells[6].Value = 0;
                    if (resultV <= v) {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
                    }
                    else {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "Ограничение не выполняется, " + " затрачено: " + resultV + " байт";
                    }
                    return;
                }
            }

        }

        bool IsCheckToPressButton() {
            for (int i = 0; i < informationMas.Count; i++) {
                if ((MyTable.Rows[i].Cells[4].Value.Equals("???")) || (MyTable.Rows[i].Cells[4].Value.Equals("")) || (Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) <= 0))
                    return false;
            }
            return true;
        }

        /*
         * Автоматическое определение решения, то есть полный перебор
         */
        private void AutoCalcWinButton_Click(object sender, EventArgs e) {
            if (LimitMemory.Text == "" || IsCheckToPressButton() == false)
                MessageBox.Show("Не все параметры введены!");
            else {
                byte[] perebWin = new byte[informationMas.Count];
                myWin = int.MinValue;
                resultV = 0;
                tmpV = 0;
                double[] arrayV = new double[informationMas.Count];
                byte[] perebor = new byte[informationMas.Count];
                v = Convert.ToDouble(LimitMemory.Text);
                for (byte i = 0; i < perebor.Length; i++) {
                    perebor[i] = 0;
                    MyTable.Rows[i].Cells[0].Value = 0;
                }
                int count = 0;
                while (NextSet(perebor, perebor.Length, count)) {
                    double tmpF = 0;
                    tmpV = 0;
                    double[] tmpArr = new double[informationMas.Count];
                    for (int i = 0; i < perebor.Length; i++) {
                        if (perebor[i] == 1) {
                            tmpV += 1.5 * Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * ToDefineType(lstWithTypeIter[i]);
                            tmpF += Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * ToCalculateDifference(lstWithTypeIter[i]);
                            tmpArr[i] = 1.5 * Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * ToDefineType(lstWithTypeIter[i]);
                        }
                        else
                            tmpArr[i] = 0;
                    }
                    if (tmpV <= v && myWin < tmpF) {
                        myWin = tmpF;
                        resultV = tmpV;
                        Array.Copy(tmpArr, arrayV, arrayV.Length);
                        Array.Copy(perebor, perebWin, perebor.Length);
                    }
                    count++;
                }

                for (int i = 0; i < perebor.Length; i++) {
                    if (perebWin[i] == 0) {
                        MyTable.Rows[i].Cells[7].Style.BackColor = Color.Red;
                        MyTable.Rows[i].Cells[7].Value = "нет";
                    }
                    else {
                        MyTable.Rows[i].Cells[0].Value = true;
                        MyTable.Rows[i].Cells[7].Style.BackColor = Color.Green;
                        MyTable.Rows[i].Cells[7].Value = "да";
                    }
                    MyTable.Rows[i].Cells[6].Value = arrayV[i];
                }
                
                labelAWithWin.Text = "";
                labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
            }
                
        }

        /*
         * Метод реализованный для вычисления разницы tList - tVector
         * Метод получает на вход тип контейнера
         * Возвращает число - разницу
         */
        private double ToCalculateDifference(string type) {
            byte size = 0;
            switch (type) {
                case "byte":
                    size = 1;
                    break;
                case "int":
                    size = 4;
                    break;
                case "double":
                    size = 8;
                    break;
                case "float":
                    size = 4;
                    break;
                case "char":
                    size = 2;
                    break;
                default:
                    size = 4;
                    break;
            }
            double result = (size / Convert.ToInt16(SList.Text)) - (size / Convert.ToInt16(SVector.Text));
            return result;
        }

        /*
         * Метод реализован для определения веса одного элемента контейнера в зависимости от типа
         * На вход получает - тип
         * На выход - число - вес
         */
        private int ToDefineType(string type) {
            switch (type) {
                case "byte":
                    return 1;
                case "int":
                    return 4;
                case "double":
                    return 8;
                case "float":
                    return 4;
                case "char":
                    return 2;
                default:
                    return 4;
            }
        }
        private void SList_Enter(object sender, EventArgs e) {
            SList.Text = "";
            SList.ForeColor = Color.Black;
        }

        private void SList_Leave(object sender, EventArgs e) {
            if (SList.Text == "") {
                SList.Text = "1";
                SList.ForeColor = Color.Silver;
            }
        }

        private void SVector_Enter(object sender, EventArgs e) {
            SVector.Text = "";
            SVector.ForeColor = Color.Black;
        }

        private void SVector_Leave(object sender, EventArgs e) {
            if (SVector.Text == "") {
                SVector.Text = "2";
                SVector.ForeColor = Color.Silver;
            }
        }
        
        /*Полный перебор*/
        bool finishFlag = true;
        bool NextSet(byte[] perebor, int n, int count) {
            if (count == 0)
                return true;
            if (finishFlag == false) {
                finishFlag = true;
                return false;
            }
            int ost = 1;
            bool flag1 = true;
            for (int i = perebor.Length - 1; i >= 0; i--) {
                if ((perebor[i] == 0) && (ost == 1)) { perebor[i] = 1; ost = 0; }
                if ((perebor[i] == 1) && (ost == 1)) { perebor[i] = 0; ost = 1; }
            }
            ost = 1;
            flag1 = true;
            for (int i = perebor.Length - 1; i >= 0; i--) { if (perebor[i] == 0) { flag1 = false; } }

            if (flag1 == true && finishFlag == true) {
                finishFlag = false;
                return true;
            }
            return true;
        }
    }
}
