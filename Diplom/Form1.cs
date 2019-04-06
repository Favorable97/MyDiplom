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
            //MyTable.ColumnCount = 2;
            MyTable.RowCount = informationMas.Count;
            int index = 0;
            foreach (KeyValuePair <string, int> tmp in informationMas) {
                MyTable.Rows[index].Cells[1].Value = tmp.Key;
                MyTable.Rows[index].Cells[2].Value = tmp.Value;
                index++;
            }
            InformForWin.Visible = true;
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

        }
    }
}
