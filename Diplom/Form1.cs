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
        }
        double tList = 4;
        double tVector = 2;
        public double myWin;
        private void CalcWinButton_Click(object sender, EventArgs e) {
            CalcWin1();
            //CalcWin2();
        }
        private void CalcWin1() {
            for (int i = 0; i < MyTable.RowCount; i++)
                myWin += 1 * Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * (tList - tVector);

            labelAWithWin.Text += myWin;
        }

        private void CalcWin2() {
            for (int i = 0; i < MyTable.RowCount; i++) {
                if (Convert.ToBoolean(MyTable.Rows[i].Cells[0].Value) == true) {
                    myWin += 1 * Convert.ToInt16(MyTable.Rows[i].Cells[4].Value) * (tList - tVector);
                }
            }
            labelAWithWin.Text += myWin;
        }
        
    }
}
