namespace Diplom {
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.ToChooseFile = new System.Windows.Forms.Button();
            this.TableWithResult = new System.Windows.Forms.DataGridView();
            this.CodeAnalysis = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWithResult)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
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
            this.ToChooseFile.Location = new System.Drawing.Point(2, 46);
            this.ToChooseFile.Name = "ToChooseFile";
            this.ToChooseFile.Size = new System.Drawing.Size(125, 35);
            this.ToChooseFile.TabIndex = 1;
            this.ToChooseFile.Text = "Выберите файл";
            this.ToChooseFile.UseVisualStyleBackColor = true;
            this.ToChooseFile.Click += new System.EventHandler(this.ToChooseFile_Click);
            // 
            // TableWithResult
            // 
            this.TableWithResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableWithResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableWithResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableWithResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableWithResult.ColumnHeadersVisible = false;
            this.TableWithResult.Location = new System.Drawing.Point(381, 46);
            this.TableWithResult.Name = "TableWithResult";
            this.TableWithResult.RowHeadersVisible = false;
            this.TableWithResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TableWithResult.Size = new System.Drawing.Size(240, 150);
            this.TableWithResult.TabIndex = 2;
            this.TableWithResult.Visible = false;
            // 
            // CodeAnalysis
            // 
            this.CodeAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeAnalysis.Location = new System.Drawing.Point(2, 98);
            this.CodeAnalysis.Name = "CodeAnalysis";
            this.CodeAnalysis.Size = new System.Drawing.Size(125, 43);
            this.CodeAnalysis.TabIndex = 3;
            this.CodeAnalysis.Text = "Начать анализ участка кода";
            this.CodeAnalysis.UseVisualStyleBackColor = true;
            this.CodeAnalysis.Click += new System.EventHandler(this.CodeAnalysis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 413);
            this.Controls.Add(this.CodeAnalysis);
            this.Controls.Add(this.TableWithResult);
            this.Controls.Add(this.ToChooseFile);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWithResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button ToChooseFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView TableWithResult;
        private System.Windows.Forms.Button CodeAnalysis;
    }
}

