using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            OpenFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //ToChooseFile.Click += ToChooseFile_Click;
            CodeAnalysis.Click += CodeAnalysis_Click;
            //MyTable.CurrentCellDirtyStateChanged += MyTable_CurrentCellDirtyStateChanged;
        }
        //List<string> lstWithNameList; // контейнер, где хранятся имена всех контейнеров C++
        //List<string> lstWithBlocks;  контейнер, где хранятся блоки со всеми циклами C++
        Dictionary<string, int> informationMas;
        string filePath;

        private void ToChooseFile_Click(object sender, EventArgs e) {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            filePath = OpenFile.FileName;
            statusStrip1.Visible = true;
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = filePath;
        }

        private void CodeAnalysis_Click(object sender, EventArgs e) {
            ParsingClass parsing = new ParsingClass(filePath);
            parsing.ParsingText();
            informationMas = parsing.informationMas;
            MyTable.Visible = true;
            MyTable.RowCount = informationMas.Count;
            ToFillTable();
            CalculationWin.Visible = true;
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

        }

        private void ToFillTable(){
            int index = 0;
            foreach (KeyValuePair<string, int> tmp in informationMas) {
                MyTable.Rows[index].Cells[1].Value = tmp.Key;
                MyTable.Rows[index].Cells[2].Value = tmp.Value;
                index++;
            }
            for (int i = 0; i < informationMas.Count; i++) {
                MyTable.Rows[i].Cells[0].Value = false;
            }
        }

        double tList = 4;
        double tVector = 2;
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
                    resultV += 1.5 * Convert.ToInt16(MyTable.Rows[index].Cells[4].Value) * 4;
                    myWin += Convert.ToInt16(MyTable.Rows[index].Cells[4].Value) * (tList - tVector);
                    if (resultV <= v) {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
                    }
                    else {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "Ограничение не выполняется, " + " затрачено: " + resultV + " байт";
                    }
                    MyTable.Rows[index].Cells[0].Value = true;
                    MyTable.Rows[index].Cells[3].Style.BackColor = Color.Green;
                    MyTable.Rows[index].Cells[3].Value = "да";

                    return;
                }
                else {
                    double tmp = 1.5 * Convert.ToInt32(MyTable.Rows[index].Cells[4].Value) * 4; 
                    resultV -= 1.5 * Convert.ToInt32(MyTable.Rows[index].Cells[4].Value) * 4;
                    myWin -= Convert.ToInt32(MyTable.Rows[index].Cells[4].Value) * (tList - tVector);

                    if (resultV <= v) {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
                    }
                    else {
                        labelAWithWin.Text = "";
                        labelAWithWin.Text = "Ограничение не выполняется, " + " затрачено: " + resultV + " байт";
                    }
                    MyTable.Rows[index].Cells[0].Value = false;
                    MyTable.Rows[index].Cells[3].Style.BackColor = Color.Red;
                    MyTable.Rows[index].Cells[3].Value = "нет";
                    //MyTable.EndEdit();
                    return;
                }
            }
            
        }

        private void AutoCalcWinButton_Click(object sender, EventArgs e) {
            byte[] perebWin = new byte[informationMas.Count];
            myWin = int.MinValue;
            resultV = 0;
            tmpV = 0;
            v = Convert.ToDouble(LimitMemory.Text);
            byte[] perebor = new byte[informationMas.Count];
            
            for (byte i = 0; i < perebor.Length; i++) {
                perebor[i] = 0;
                MyTable.Rows[0].Cells[i].Value = 0;
            }
                
            int count = 0;
            while (NextSet(perebor, perebor.Length, count)) {
                double tmpF = 0;
                tmpV = 0;
                for (int i = 0; i < perebor.Length; i++) {
                    if (perebor[i] == 1) {
                        tmpV += 1.5 * Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * 4;
                        tmpF += Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * (tList - tVector);
                    }
                }
                if (tmpV <= v && myWin < tmpF) {
                    myWin = tmpF;
                    resultV = tmpV;
                    Array.Copy(perebor, perebWin, perebor.Length);
                }
                count++;
            }

            for (int i = 0; i < perebor.Length; i++) {
                if (perebWin[i] == 0) {
                    MyTable.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    MyTable.Rows[i].Cells[3].Value = "нет";
                }
                else {
                    MyTable.Rows[i].Cells[0].Value = true;
                    MyTable.Rows[i].Cells[3].Style.BackColor = Color.Green;
                    MyTable.Rows[i].Cells[3].Value = "да";
                }
                    
            }
            labelAWithWin.Text = "";
            labelAWithWin.Text = "F = " + myWin + " затрачено " + resultV + " байт";
        }
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
