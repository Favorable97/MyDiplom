﻿namespace Diplom {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ToChooseFile = new System.Windows.Forms.Button();
            this.CodeAnalysis = new System.Windows.Forms.Button();
            this.MyTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculationWin = new System.Windows.Forms.GroupBox();
            this.SVector = new System.Windows.Forms.TextBox();
            this.AutoCalcWinButton = new System.Windows.Forms.Button();
            this.labelAWithWin = new System.Windows.Forms.Label();
            this.SList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LimitMemory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            this.CalculationWin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1344, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // OpenFile
            // 
            this.OpenFile.RestoreDirectory = true;
            // 
            // ToChooseFile
            // 
            this.ToChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToChooseFile.Location = new System.Drawing.Point(502, 31);
            this.ToChooseFile.Name = "ToChooseFile";
            this.ToChooseFile.Size = new System.Drawing.Size(125, 35);
            this.ToChooseFile.TabIndex = 1;
            this.ToChooseFile.Text = "Выберите файл";
            this.ToChooseFile.UseVisualStyleBackColor = true;
            this.ToChooseFile.Click += new System.EventHandler(this.ToChooseFile_Click);
            // 
            // CodeAnalysis
            // 
            this.CodeAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeAnalysis.Location = new System.Drawing.Point(502, 90);
            this.CodeAnalysis.Name = "CodeAnalysis";
            this.CodeAnalysis.Size = new System.Drawing.Size(125, 43);
            this.CodeAnalysis.TabIndex = 3;
            this.CodeAnalysis.Text = "Начать анализ участка кода";
            this.CodeAnalysis.UseVisualStyleBackColor = true;
            this.CodeAnalysis.Click += new System.EventHandler(this.CodeAnalysis_Click);
            // 
            // MyTable
            // 
            this.MyTable.AllowUserToAddRows = false;
            this.MyTable.AllowUserToDeleteRows = false;
            this.MyTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MyTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column4});
            this.MyTable.Location = new System.Drawing.Point(572, 230);
            this.MyTable.Name = "MyTable";
            this.MyTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MyTable.Size = new System.Drawing.Size(635, 44);
            this.MyTable.TabIndex = 4;
            this.MyTable.Visible = false;
            this.MyTable.CurrentCellDirtyStateChanged += new System.EventHandler(this.MyTable_CurrentCellDirtyStateChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 6.791172F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 119.1196F;
            this.Column2.HeaderText = "Итератор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 70;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 72.88135F;
            this.Column8.HeaderText = "Тип";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 69;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 138.9695F;
            this.Column3.HeaderText = "Номер строки";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 184.1371F;
            this.Column5.HeaderText = "Количество элементов";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 102.9744F;
            this.Column6.HeaderText = "tList - tVector";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 44.89193F;
            this.Column7.HeaderText = "V";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 130.235F;
            this.Column4.HeaderText = "Рекомендации";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // CalculationWin
            // 
            this.CalculationWin.AutoSize = true;
            this.CalculationWin.Controls.Add(this.SVector);
            this.CalculationWin.Controls.Add(this.AutoCalcWinButton);
            this.CalculationWin.Controls.Add(this.labelAWithWin);
            this.CalculationWin.Controls.Add(this.SList);
            this.CalculationWin.Controls.Add(this.label7);
            this.CalculationWin.Controls.Add(this.label3);
            this.CalculationWin.Controls.Add(this.label8);
            this.CalculationWin.Controls.Add(this.label2);
            this.CalculationWin.Controls.Add(this.label4);
            this.CalculationWin.Controls.Add(this.LimitMemory);
            this.CalculationWin.Controls.Add(this.label1);
            this.CalculationWin.Controls.Add(this.label5);
            this.CalculationWin.Controls.Add(this.label6);
            this.CalculationWin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculationWin.Location = new System.Drawing.Point(659, 12);
            this.CalculationWin.Name = "CalculationWin";
            this.CalculationWin.Size = new System.Drawing.Size(365, 186);
            this.CalculationWin.TabIndex = 5;
            this.CalculationWin.TabStop = false;
            this.CalculationWin.Text = "Данные для подсчёта выигрыша";
            this.CalculationWin.Visible = false;
            // 
            // SVector
            // 
            this.SVector.ForeColor = System.Drawing.Color.Silver;
            this.SVector.Location = new System.Drawing.Point(87, 69);
            this.SVector.Name = "SVector";
            this.SVector.Size = new System.Drawing.Size(39, 29);
            this.SVector.TabIndex = 10;
            this.SVector.Text = "2";
            this.SVector.Enter += new System.EventHandler(this.SVector_Enter);
            this.SVector.Leave += new System.EventHandler(this.SVector_Leave);
            // 
            // AutoCalcWinButton
            // 
            this.AutoCalcWinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoCalcWinButton.Location = new System.Drawing.Point(161, 54);
            this.AutoCalcWinButton.Name = "AutoCalcWinButton";
            this.AutoCalcWinButton.Size = new System.Drawing.Size(137, 46);
            this.AutoCalcWinButton.TabIndex = 7;
            this.AutoCalcWinButton.Text = "Автоматический расчёт";
            this.AutoCalcWinButton.UseVisualStyleBackColor = true;
            this.AutoCalcWinButton.Click += new System.EventHandler(this.AutoCalcWinButton_Click);
            // 
            // labelAWithWin
            // 
            this.labelAWithWin.AutoSize = true;
            this.labelAWithWin.Location = new System.Drawing.Point(9, 140);
            this.labelAWithWin.Name = "labelAWithWin";
            this.labelAWithWin.Size = new System.Drawing.Size(0, 21);
            this.labelAWithWin.TabIndex = 6;
            // 
            // SList
            // 
            this.SList.ForeColor = System.Drawing.Color.Silver;
            this.SList.Location = new System.Drawing.Point(75, 36);
            this.SList.Name = "SList";
            this.SList.Size = new System.Drawing.Size(39, 29);
            this.SList.TabIndex = 9;
            this.SList.Text = "1";
            this.SList.Enter += new System.EventHandler(this.SList_Enter);
            this.SList.Leave += new System.EventHandler(this.SList_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "V = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = " = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "байт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "s";
            // 
            // LimitMemory
            // 
            this.LimitMemory.Location = new System.Drawing.Point(52, 111);
            this.LimitMemory.Name = "LimitMemory";
            this.LimitMemory.Size = new System.Drawing.Size(62, 29);
            this.LimitMemory.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "vector";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = " = ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(478, 467);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 494);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Код программы C++";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1250, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalculationWin);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.CodeAnalysis);
            this.Controls.Add(this.ToChooseFile);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Desctop Project";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
            this.CalculationWin.ResumeLayout(false);
            this.CalculationWin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button ToChooseFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button CodeAnalysis;
        private System.Windows.Forms.DataGridView MyTable;
        private System.Windows.Forms.GroupBox CalculationWin;
        private System.Windows.Forms.TextBox LimitMemory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AutoCalcWinButton;
        private System.Windows.Forms.Label labelAWithWin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SVector;
        private System.Windows.Forms.TextBox SList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

