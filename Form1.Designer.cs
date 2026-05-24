namespace ArrayLab9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.nudM = new System.Windows.Forms.NumericUpDown();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.lstB = new System.Windows.Forms.ListBox();
            this.lblStat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(10, 10);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(68, 16);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N (строк):";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(150, 10);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(91, 16);
            this.lblM.TabIndex = 1;
            this.lblM.Text = "M (столбцов):";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(90, 7);
            this.nudN.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(50, 22);
            this.nudN.TabIndex = 2;
            this.nudN.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // nudM
            // 
            this.nudM.Location = new System.Drawing.Point(240, 7);
            this.nudM.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudM.Name = "nudM";
            this.nudM.Size = new System.Drawing.Size(50, 22);
            this.nudM.TabIndex = 3;
            this.nudM.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(310, 5);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(130, 26);
            this.btnFill.TabIndex = 4;
            this.btnFill.Text = "Заполнить матрицу";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(450, 5);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(130, 26);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "Построить массив";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // dgvA
            // 
            this.dgvA.AllowUserToAddRows = false;
            this.dgvA.AllowUserToDeleteRows = false;
            this.dgvA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(10, 40);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersWidth = 51;
            this.dgvA.Size = new System.Drawing.Size(600, 300);
            this.dgvA.TabIndex = 6;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Location = new System.Drawing.Point(10, 360);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(200, 164);
            this.lstB.TabIndex = 7;
            // 
            // lblStat
            // 
            this.lblStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat.Location = new System.Drawing.Point(230, 360);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(380, 160);
            this.lblStat.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.dgvA);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.nudM);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вариант 5. Гаврилов А.В. ИС24 — массив из чётных столбцов";
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.NumericUpDown nudM;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Label lblStat;
    }
}