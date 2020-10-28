using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double A = Convert.ToDouble(textBox1.Text);
                double B = Convert.ToDouble(textBox2.Text);
                double D = A + B;
                textBox4.Text = D.ToString();
            }
            else
    if (comboBox1.SelectedIndex == 1)
            {
                double A = Convert.ToDouble(textBox1.Text);
                double B = Convert.ToDouble(textBox2.Text);
                double D = A - B;
                textBox4.Text = D.ToString();
            }
            else
    if (comboBox1.SelectedIndex == 2)
            {
                double A = Convert.ToDouble(textBox1.Text);
                double B = Convert.ToDouble(textBox2.Text);
                double D = A * B;
                textBox4.Text = D.ToString();
            }
            else
    if (comboBox1.SelectedIndex == 3)
            {
                double A = Convert.ToDouble(textBox1.Text);
                double B = Convert.ToDouble(textBox2.Text);
                double D = A / B;
                textBox4.Text = D.ToString();
            }
            else
    if (comboBox1.SelectedIndex == 4)
                {
                    MessageBox.Show("Всё правильно `78` !!!");
                }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//BY TUSTUGASHEV Y.V.
