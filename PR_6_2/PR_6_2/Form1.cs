using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Опишем событие Load формы для задания начального количества строк и столбцов:
        private void Form1_Load(object sender, EventArgs e)
        {
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value); 
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);

        //Размерность матрицы и количество столбцов массива одинаковые
            Mas_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value); 
            Mas_DGV.RowCount = 1;
        }
        //Опишем событие ValueChanged компонента Count_NUD:
        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Mas_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }
        //Опишем событие Click кнопки Calc_B:
        private void Calc_B_Click(object sender, EventArgs e)
        {
            double[] mas = new double[Mas_DGV.ColumnCount]; 
            int[,] matr = new int[Matr_DGV.RowCount,Matr_DGV.ColumnCount];
            int i, j;

        //Заполнение матрицы
            for (i = 0; i < Matr_DGV.RowCount; i++)
                for (j = 0; j < Matr_DGV.ColumnCount; j++)
                    matr[i, j] = Convert.ToInt32(Matr_DGV[j, i].Value);

        //Перебор строк матрицы
            for (i = 0; i < Matr_DGV.RowCount; i++)
            {
        //Для каждой строки находится сумма ее элементов
                mas[i] = 0;
                for (j = 0; j < Matr_DGV.ColumnCount; j++) 
                    mas[i] += matr[i, j];

        //Для нахождения среднего сумма элементов строки делится на их количество
                mas[i] /= Matr_DGV.ColumnCount;
            }
        //Сортировка массива
            i = 0;
            while (i < Matr_DGV.ColumnCount - 1)
                if (mas[i] > mas[i + 1])
                {
                    double temp = mas[i]; 
                    mas[i] = mas[i + 1]; 
                    mas[i + 1] = temp;
                    if (i > 0)
                        i--;
                    else 
                        i++;
                }

                else
                    i++;

        //Вывод массива
                for (i = 0; i < Matr_DGV.ColumnCount; i++)
                    Mas_DGV[i, 0].Value = mas[i];
        }
    }
}
//BY TUSTUGASHEV Y.V.
