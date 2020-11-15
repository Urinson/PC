using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_9
{
    public partial class People_F : Form
    {
        public People_F()
        {
            InitializeComponent();
        }
        private void People_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Проверку следует проводить только при нажатии кнопки "Ok" */
            if (DialogResult == DialogResult.OK)

                /* Будем использовать обработку исключительных ситуаций
                для проверки на правильность ввода и вывода информации об ошибках */
                try
                {
                    /* Проверка ФИО */
                    if (FIO_TB.Text.Trim() == "") // Если ничего не введено
                    {
                        /* Перевод фокуса ввода на компонент FIO_TB */
                        FIO_TB.Focus();

                        /* Вызов исключительной ситуации с текстом ошибки */
                        throw new Exception("Вы не ввели ФИО человека");
                    }
                    /* Проверка серии паспорта */
                    if (Series_TB.Text.Trim() == "")
                    {
                        Series_TB.Focus();
                        throw new Exception("Вы не ввели серию паспорта");
                    }
                    /* Получение значения номера паспорта */
                    int n = Convert.ToInt32(Number_TB.Text);

                    /* Проверка значения номера паспорта на вхождение в заданный диапазон */
                    if (n < 1 || n > 999999)

                    {
                        Number_TB.Focus();
                        throw new Exception("Номер паспорта должен быть в диапазоне 1..999999");
                    }
                }
                /* Если введенное значение номера паспорта не целое число, то обработка данной ошибки */
                catch (FormatException)
                {
                    e.Cancel = true; Number_TB.Focus(); MessageBox.Show("Номер паспорта должен быть целым числом", "Ошибка");
                }
                /* Обработка всех других ошибок */
                catch (Exception E)
                {
                    e.Cancel = true;

                    MessageBox.Show(E.Message, "Ошибка"); // E.Message – текст ошибки
                }
        }
        private void People_F_Shown(object sender, EventArgs e)
        {
            /* При открытии формы переход на компонент FIO_TB */
            FIO_TB.Focus();
        }
    }
}
//BY TUSTUGASHEV Y.V.