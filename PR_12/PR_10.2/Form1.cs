using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PR_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Добавление";
            if (f.ShowDialog() == DialogResult.OK)
            {
                timer1.Stop();
                int x = Convert.ToInt32(f.numericUpDown1.Value);
                int y = Convert.ToInt32(f.numericUpDown2.Value);
                int l = Convert.ToInt32(f.numericUpDown3.Value);
                int s = Convert.ToInt32(f.numericUpDown4.Value);
                Color cl = f.pictureBox1.BackColor;
                Risunok kv = new Risunok(x, y, l, s, cl, pictureBox1);
                listBox1.Items.Add(kv);
                timer1.Start();
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            timer1.Start();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                m.Stir();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form2 f = new Form2();
                f.Text = "Редактировать";
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                f.numericUpDown1.Value = m.x;
                f.numericUpDown2.Value = m.y;
                f.numericUpDown3.Value = m.l;
                f.numericUpDown4.Value = m.s;
                f.pictureBox1.BackColor = m.myColor;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    timer1.Stop();
                    m.Stir();
                    int x = Convert.ToInt32(f.numericUpDown1.Value);
                    int y = Convert.ToInt32(f.numericUpDown2.Value);
                    int l = Convert.ToInt32(f.numericUpDown3.Value);
                    int s = Convert.ToInt32(f.numericUpDown4.Value);
                    Color cl = f.pictureBox1.BackColor;
                    m.x = x; m.y = y; m.l = l; m.s = s; m.myColor = cl;
                    listBox1.Items[listBox1.SelectedIndex] = m;
                    timer1.Start();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Risunok m = listBox1.Items[i] as Risunok;
                m.Dviz();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Добавление";
            if (f.ShowDialog() == DialogResult.OK)
            {
                timer1.Stop();
                int x = Convert.ToInt32(f.numericUpDown1.Value);
                int y = Convert.ToInt32(f.numericUpDown2.Value);
                int l = Convert.ToInt32(f.numericUpDown3.Value);
                int s = Convert.ToInt32(f.numericUpDown4.Value);
                Color cl = f.pictureBox1.BackColor;
                Risunok kv = new Risunok(x, y, l, s, cl, pictureBox1);
                listBox1.Items.Add(kv);
                timer1.Start();
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Добавление";
            if (f.ShowDialog() == DialogResult.OK)
            {
                timer1.Stop();
                int x = Convert.ToInt32(f.numericUpDown1.Value);
                int y = Convert.ToInt32(f.numericUpDown2.Value);
                int l = Convert.ToInt32(f.numericUpDown3.Value);
                int s = Convert.ToInt32(f.numericUpDown4.Value);
                Color cl = f.pictureBox1.BackColor;
                Risunok kv = new Risunok(x, y, l, s, cl, pictureBox1);
                listBox1.Items.Add(kv);
                timer1.Start();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                m.Stir();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                m.Stir();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form2 f = new Form2();
                f.Text = "Редактировать";
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                f.numericUpDown1.Value = m.x;
                f.numericUpDown2.Value = m.y;
                f.numericUpDown3.Value = m.l;
                f.numericUpDown4.Value = m.s;
                f.pictureBox1.BackColor = m.myColor;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    timer1.Stop();
                    m.Stir();
                    int x = Convert.ToInt32(f.numericUpDown1.Value);
                    int y = Convert.ToInt32(f.numericUpDown2.Value);
                    int l = Convert.ToInt32(f.numericUpDown3.Value);
                    int s = Convert.ToInt32(f.numericUpDown4.Value);
                    Color cl = f.pictureBox1.BackColor;
                    m.x = x; m.y = y; m.l = l; m.s = s; m.myColor = cl;
                    listBox1.Items[listBox1.SelectedIndex] = m;
                    timer1.Start();
                }
            }
        }
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form2 f = new Form2();
                f.Text = "Редактировать";
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                f.numericUpDown1.Value = m.x;
                f.numericUpDown2.Value = m.y;
                f.numericUpDown3.Value = m.l;
                f.numericUpDown4.Value = m.s;
                f.pictureBox1.BackColor = m.myColor;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    timer1.Stop();
                    m.Stir();
                    int x = Convert.ToInt32(f.numericUpDown1.Value);
                    int y = Convert.ToInt32(f.numericUpDown2.Value);
                    int l = Convert.ToInt32(f.numericUpDown3.Value);
                    int s = Convert.ToInt32(f.numericUpDown4.Value);
                    Color cl = f.pictureBox1.BackColor;
                    m.x = x; m.y = y; m.l = l; m.s = s; m.myColor = cl;
                    listBox1.Items[listBox1.SelectedIndex] = m;
                    timer1.Start();
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tustugashev Y.V. 2020");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                редактироватьToolStripMenuItem.Enabled = true;
                удалитьToolStripMenuItem.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                toolStripStatusLabel1.Text = ("Масштаб=(" + m.l + ")");
                toolStripStatusLabel2.Text = ("Скорость=(" + m.s + ")");
                toolStripStatusLabel3.Text = ("Цвет=(" + m.myColor + ")");
                toolStripStatusLabel4.Text = ("X=(" + m.x + ")");
                toolStripStatusLabel5.Text = ("Y=(" + m.y + ")");
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            saveFileDialog1.Filter = "Config files(*.zzz)|*.zzz|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            MessageBox.Show("Файл сохранен");

            //            saveFileDialog1.FileName = "";
            //            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(listBox1.Items.Count);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Risunok m = listBox1.Items[i] as Risunok;
                        sw.WriteLine(m.x);
                        sw.WriteLine(m.y);
                        sw.WriteLine(m.l);
                        sw.WriteLine(m.s);
                        sw.WriteLine(m.myColor);
                        timer1.Start();
                    }
                }
            }
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            openFileDialog1.Filter = "Config files(*.zzz)|*.zzz|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);

            listBox1.Items.Clear();
            //openFileDialog1.FileName = "";
            //            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Файл открыт");

                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    int k = Convert.ToInt32(sr.ReadLine());
                    for (int i = 0; i < k; i++)
                    {
                        int x = Convert.ToInt32(sr.ReadLine());
                        int y = Convert.ToInt32(sr.ReadLine());
                        int l = Convert.ToInt32(sr.ReadLine());
                        int s = Convert.ToInt32(sr.ReadLine());
                        string cl = sr.ReadLine();
                        Color mycl = Color.FromName(cl);

                        Risunok my = new Risunok(x, y, l, s, mycl, pictureBox1);
                        listBox1.Items.Add(my);
                        timer1.Start();
                    }
                }
            }

        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                timer1.Stop();

                openFileDialog1.Filter = "Config files(*.zzz)|*.zzz|All files(*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = System.IO.File.ReadAllText(filename);

                listBox1.Items.Clear();
                //openFileDialog1.FileName = "";
                //            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Файл открыт");

                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        int k = Convert.ToInt32(sr.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            int x = Convert.ToInt32(sr.ReadLine());
                            int y = Convert.ToInt32(sr.ReadLine());
                            int l = Convert.ToInt32(sr.ReadLine());
                            int s = Convert.ToInt32(sr.ReadLine());
                            string cl = sr.ReadLine();
                            Color mycl = Color.FromName(cl);

                            Risunok my = new Risunok(x, y, l, s, mycl, pictureBox1);
                            listBox1.Items.Add(my);
                            timer1.Start();
                        }
                    }
                }
            }
        }
        private void записьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            saveFileDialog1.Filter = "Config files(*.zzz)|*.zzz|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            MessageBox.Show("Файл сохранен");

            //            saveFileDialog1.FileName = "";
            //            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(listBox1.Items.Count);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Risunok m = listBox1.Items[i] as Risunok;
                        sw.WriteLine(m.x);
                        sw.WriteLine(m.y);
                        sw.WriteLine(m.l);
                        sw.WriteLine(m.s);
                        sw.WriteLine(m.myColor);
                        timer1.Start();
                    }
                }
            }
        }
    }
}
//BY TUSTUGASHEV Y.V.