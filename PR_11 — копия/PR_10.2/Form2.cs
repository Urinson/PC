using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_10._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    if (Convert.ToInt32(numericUpDown1.Value) == 0)
                    {
                        throw new Exception("Введите Х > 0");
                    }
                    k++;
                    if (Convert.ToInt32(numericUpDown2.Value) == 0)
                    {
                        throw new Exception("Введите Скорость > 0");
                    }
                    k++;
                    if (Convert.ToInt32(numericUpDown3.Value) == 0)
                    {
                        throw new Exception("Введите Размер > 0");
                    }
                    k++;
                    if (Convert.ToInt32(numericUpDown4.Value) == 0)
                    {
                        throw new Exception("Введите Y > 0");
                    }
                }
                catch (Exception E)
                {
                    if (k == 0) numericUpDown1.Focus();
                    if (k == 1) numericUpDown2.Focus();
                    if (k == 2) numericUpDown3.Focus();
                    if (k == 3) numericUpDown4.Focus();
                    MessageBox.Show(E.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}
//BY TUSTUGASHEV Y.V.