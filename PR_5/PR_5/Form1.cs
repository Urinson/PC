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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                double C = A + B;
                textBox3.Text = C.ToString();
            }
            else
                if (radioButton2.Checked == true)
            {
                double C = A - B;
                textBox3.Text = C.ToString();
            }
            else
                if (radioButton3.Checked == true)
            {
                double C = A * B;
                textBox3.Text = C.ToString();
            }
            else
                if (radioButton4.Checked == true)

            {
                double C = A / B;
                textBox3.Text = C.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//BY TUSTUGASHEV Y.V.