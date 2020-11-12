namespace PR_9
{
    partial class People_F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel_B = new System.Windows.Forms.Button();
            this.Ok_B = new System.Windows.Forms.Button();
            this.FIO_L = new System.Windows.Forms.Label();
            this.Series_L = new System.Windows.Forms.Label();
            this.Number_L = new System.Windows.Forms.Label();
            this.FIO_TB = new System.Windows.Forms.TextBox();
            this.Series_TB = new System.Windows.Forms.TextBox();
            this.Number_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(659, 159);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(100, 47);
            this.Cancel_B.TabIndex = 3;
            this.Cancel_B.Text = "Отм&ена";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // Ok_B
            // 
            this.Ok_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_B.Location = new System.Drawing.Point(513, 159);
            this.Ok_B.Name = "Ok_B";
            this.Ok_B.Size = new System.Drawing.Size(100, 47);
            this.Ok_B.TabIndex = 2;
            this.Ok_B.Text = "OK";
            this.Ok_B.UseVisualStyleBackColor = true;
            // 
            // FIO_L
            // 
            this.FIO_L.AutoSize = true;
            this.FIO_L.Location = new System.Drawing.Point(12, 30);
            this.FIO_L.Name = "FIO_L";
            this.FIO_L.Size = new System.Drawing.Size(135, 20);
            this.FIO_L.TabIndex = 4;
            this.FIO_L.Text = "Ф.И.О. &человека";
            // 
            // Series_L
            // 
            this.Series_L.AutoSize = true;
            this.Series_L.Location = new System.Drawing.Point(12, 71);
            this.Series_L.Name = "Series_L";
            this.Series_L.Size = new System.Drawing.Size(131, 20);
            this.Series_L.TabIndex = 5;
            this.Series_L.Text = "Се&рия паспорта";
            // 
            // Number_L
            // 
            this.Number_L.AutoSize = true;
            this.Number_L.Location = new System.Drawing.Point(12, 116);
            this.Number_L.Name = "Number_L";
            this.Number_L.Size = new System.Drawing.Size(134, 20);
            this.Number_L.TabIndex = 6;
            this.Number_L.Text = "Но&мер паспорта";
            // 
            // FIO_TB
            // 
            this.FIO_TB.Location = new System.Drawing.Point(177, 24);
            this.FIO_TB.Name = "FIO_TB";
            this.FIO_TB.Size = new System.Drawing.Size(578, 26);
            this.FIO_TB.TabIndex = 7;
            //this.FIO_TB.TextChanged += new System.EventHandler(this.FIO_TB_TextChanged);
            // 
            // Series_TB
            // 
            this.Series_TB.Location = new System.Drawing.Point(177, 65);
            this.Series_TB.Name = "Series_TB";
            this.Series_TB.Size = new System.Drawing.Size(396, 26);
            this.Series_TB.TabIndex = 8;
            // 
            // Number_TB
            // 
            this.Number_TB.Location = new System.Drawing.Point(177, 110);
            this.Number_TB.Name = "Number_TB";
            this.Number_TB.Size = new System.Drawing.Size(396, 26);
            this.Number_TB.TabIndex = 9;
            //this.Number_TB.TextChanged += new System.EventHandler(this.Number_TB_TextChanged);
            // 
            // People_F
            // 
            this.AcceptButton = this.Ok_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(781, 220);
            this.Controls.Add(this.Number_TB);
            this.Controls.Add(this.Series_TB);
            this.Controls.Add(this.FIO_TB);
            this.Controls.Add(this.Number_L);
            this.Controls.Add(this.Series_L);
            this.Controls.Add(this.FIO_L);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.Ok_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "People_F";
            this.ShowInTaskbar = false;
            this.Text = "Изменение даннх человека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.People_F_FormClosing);
           // this.Load += new System.EventHandler(this.People_F_Load);
            this.Shown += new System.EventHandler(this.People_F_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Button Ok_B;
        private System.Windows.Forms.Label FIO_L;
        private System.Windows.Forms.Label Series_L;
        private System.Windows.Forms.Label Number_L;
        public System.Windows.Forms.TextBox FIO_TB;
        public System.Windows.Forms.TextBox Series_TB;
        public System.Windows.Forms.TextBox Number_TB;
    }
}