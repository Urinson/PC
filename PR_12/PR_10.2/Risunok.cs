using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_10._2
{
    class Risunok
    {
        public int x, y, l, s, dy;
        public Color myColor;
        PictureBox mybox;
        public Risunok(int n_x, int n_y, int n_l, int n_s, Color n_myColor, PictureBox n_mybox)
        {
            x = n_x;
            y = n_y;
            l = n_l;
            s = n_s;
            mybox = n_mybox;
            myColor = n_myColor;
            dy = s;
            Risovanie();
        }
        public void Risovanie()
        {
            Pen p = new Pen(Color.Red, 3);
            SolidBrush brush = new SolidBrush(Color.LightSkyBlue);
            SolidBrush brush2 = new SolidBrush(myColor);
            Graphics g = Graphics.FromImage(mybox.Image);
            g.FillRectangle(brush, x, y, l, l);
            g.DrawRectangle(p, x, y, l, l);
            g.DrawLine(p, x + l, y, x, y + l);
            g.DrawLine(p, x, y, x + l, y + l);
            g.FillEllipse(brush2, x + l / 2 - l / 8, y + l / 12, l / 4, l / 4);
            g.FillEllipse(brush2, x + l / 2 - l / 8, y + l - l / 3, l / 4, l / 4);
            mybox.Refresh();
        }
        public void Stir()
        {
            Graphics g = Graphics.FromImage(mybox.Image);
            SolidBrush brush1 = new SolidBrush(Color.White);
            g.FillRectangle(brush1, x, y, l, l);
            Pen p1 = new Pen(Color.White, 3);
            g.DrawRectangle(p1, x, y, l, l);
            mybox.Refresh();
        }
        public void Dviz()
        {
            Stir();

            int y1 = y + dy;
            if (y1 < 0 || y1 > (mybox.Height - l))
            {
                dy = -dy;
            }
            y = y + dy;
            Risovanie();
        }
        public override string ToString()
        {
            return ("Масштаб- " + l + " цвет-" + myColor);
        }
    }
}
//TUSTUGASHEV Y.V.