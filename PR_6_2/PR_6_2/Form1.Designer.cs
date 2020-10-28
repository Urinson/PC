namespace PR_6_2
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
            this.Mas_L = new System.Windows.Forms.Label();
            this.Calc_B = new System.Windows.Forms.Button();
            this.Matr_L = new System.Windows.Forms.Label();
            this.Count_L = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.Matr_DGV = new System.Windows.Forms.DataGridView();
            this.Mas_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mas_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Mas_L
            // 
            this.Mas_L.AutoSize = true;
            this.Mas_L.Location = new System.Drawing.Point(454, 53);
            this.Mas_L.Name = "Mas_L";
            this.Mas_L.Size = new System.Drawing.Size(161, 20);
            this.Mas_L.TabIndex = 12;
            this.Mas_L.Text = "Полученный ма&ссив";
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(458, 15);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(97, 35);
            this.Calc_B.TabIndex = 11;
            this.Calc_B.Text = "Рас&чет";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Matr_L
            // 
            this.Matr_L.AutoSize = true;
            this.Matr_L.Location = new System.Drawing.Point(12, 53);
            this.Matr_L.Name = "Matr_L";
            this.Matr_L.Size = new System.Drawing.Size(151, 20);
            this.Matr_L.TabIndex = 9;
            this.Matr_L.Text = "Исходная матри&ца";
            // 
            // Count_L
            // 
            this.Count_L.AutoSize = true;
            this.Count_L.Location = new System.Drawing.Point(12, 16);
            this.Count_L.Name = "Count_L";
            this.Count_L.Size = new System.Drawing.Size(211, 20);
            this.Count_L.TabIndex = 7;
            this.Count_L.Text = "Ра&змер исходной матрицы";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(245, 14);
            this.Count_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Count_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(120, 26);
            this.Count_NUD.TabIndex = 15;
            this.Count_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Count_NUD.ValueChanged += new System.EventHandler(this.Count_NUD_ValueChanged);
            // 
            // Matr_DGV
            // 
            this.Matr_DGV.AllowUserToAddRows = false;
            this.Matr_DGV.AllowUserToDeleteRows = false;
            this.Matr_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matr_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Matr_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matr_DGV.ColumnHeadersVisible = false;
            this.Matr_DGV.Location = new System.Drawing.Point(16, 76);
            this.Matr_DGV.Name = "Matr_DGV";
            this.Matr_DGV.RowHeadersVisible = false;
            this.Matr_DGV.RowHeadersWidth = 62;
            this.Matr_DGV.RowTemplate.Height = 28;
            this.Matr_DGV.Size = new System.Drawing.Size(426, 315);
            this.Matr_DGV.TabIndex = 16;
            // 
            // Mas_DGV
            // 
            this.Mas_DGV.AllowUserToDeleteRows = false;
            this.Mas_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mas_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Mas_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mas_DGV.ColumnHeadersVisible = false;
            this.Mas_DGV.Location = new System.Drawing.Point(458, 76);
            this.Mas_DGV.Name = "Mas_DGV";
            this.Mas_DGV.ReadOnly = true;
            this.Mas_DGV.RowHeadersVisible = false;
            this.Mas_DGV.RowHeadersWidth = 62;
            this.Mas_DGV.RowTemplate.Height = 28;
            this.Mas_DGV.Size = new System.Drawing.Size(426, 65);
            this.Mas_DGV.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 409);
            this.Controls.Add(this.Mas_DGV);
            this.Controls.Add(this.Matr_DGV);
            this.Controls.Add(this.Count_NUD);
            this.Controls.Add(this.Mas_L);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Matr_L);
            this.Controls.Add(this.Count_L);
            this.Name = "Form1";
            this.Text = "Тустугашев Я.В. ПР_6";
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mas_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Mas_L;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.Label Matr_L;
        private System.Windows.Forms.Label Count_L;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.DataGridView Matr_DGV;
        private System.Windows.Forms.DataGridView Mas_DGV;
    }
}

