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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dateTimePicker1.Value.ToString();

            textBox1.Text = dateTimePicker1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Изменяет дату из monthCalendar1 в textBox2
            textBox2.Text = monthCalendar1.SelectionRange.Start.ToString();

            //Выводи дату из dateTimePicker1 в отдельное окно и меняет ее оставляя текущее время
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}
//BY TUSTUGASHEV Y.V.
