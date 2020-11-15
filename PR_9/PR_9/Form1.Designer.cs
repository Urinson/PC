namespace PR_9
{
    partial class Main_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_F));
            this.Add_B = new System.Windows.Forms.Button();
            this.Change_B = new System.Windows.Forms.Button();
            this.Del_B = new System.Windows.Forms.Button();
            this.Spisok_L = new System.Windows.Forms.Label();
            this.Spisok_LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(577, 58);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(100, 47);
            this.Add_B.TabIndex = 0;
            this.Add_B.Text = "Доб&авить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Change_B
            // 
            this.Change_B.Location = new System.Drawing.Point(577, 122);
            this.Change_B.Name = "Change_B";
            this.Change_B.Size = new System.Drawing.Size(100, 50);
            this.Change_B.TabIndex = 1;
            this.Change_B.Text = "И&зменить";
            this.Change_B.UseVisualStyleBackColor = true;
            this.Change_B.Click += new System.EventHandler(this.Change_B_Click);
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(577, 188);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(100, 48);
            this.Del_B.TabIndex = 2;
            this.Del_B.Text = "Уда&лить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Spisok_L
            // 
            this.Spisok_L.AutoSize = true;
            this.Spisok_L.Location = new System.Drawing.Point(12, 19);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Size = new System.Drawing.Size(118, 20);
            this.Spisok_L.TabIndex = 3;
            this.Spisok_L.Text = "Спи&cок людей";
            // 
            // Spisok_LB
            // 
            this.Spisok_LB.FormattingEnabled = true;
            this.Spisok_LB.ItemHeight = 20;
            this.Spisok_LB.Location = new System.Drawing.Point(16, 58);
            this.Spisok_LB.Name = "Spisok_LB";
            this.Spisok_LB.Size = new System.Drawing.Size(545, 364);
            this.Spisok_LB.TabIndex = 4;
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.Spisok_LB);
            this.Controls.Add(this.Spisok_L);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Change_B);
            this.Controls.Add(this.Add_B);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_F";
            this.Text = "PR_8_Диалоговые окна Tustugashev Y.V.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Change_B;
        private System.Windows.Forms.Button Del_B;
        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.ListBox Spisok_LB;
    }
}

