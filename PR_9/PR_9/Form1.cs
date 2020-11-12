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
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }
        private void Add_B_Click(object sender, EventArgs e)
        {
            /* Перед работой с диалоговой формой ее нужно создать */
            People_F Dialog = new People_F();

            /* Изменение заголовка диалогового окна */
            Dialog.Text = "Добавление человека";
            
            /* Установка значений полей ввода диалогового окна в
            значение “по умолчанию” */
            Dialog.FIO_TB.Text = ""; Dialog.Series_TB.Text = ""; Dialog.Number_TB.Text = "";

            /* Вызов диалогового окна и проверка результата завершения
            его работы. Если окно закрыто с подтверждением ввода данных,
            то выполнение действий по созданию нового элемента */
            if (Dialog.ShowDialog() == DialogResult.OK)

            {
                /* Создание экземпляра класса */
                TPeople People = new TPeople();

                /* Заполнение свойств экземпляра класса */
                People.FIO = Dialog.FIO_TB.Text.Trim(); People.Series = Dialog.Series_TB.Text.Trim();

                People.Number = Convert.ToInt32(Dialog.Number_TB.Text);

                /* Добавление нового элемента в список людей */
                Spisok_LB.Items.Add(People);
            }
        }
        private void Change_B_Click(object sender, EventArgs e)
        {
            /* Проверка, выбран ли элемент для редактирования */
            if (Spisok_LB.SelectedIndex != -1)
            {
                /* Перед работой с диалоговой формой ее нужно создать */
                People_F Dialog = new People_F();

                /* Установка заголовка диалогового окна */
                Dialog.Text = "Изменение данных человека";

                /* Получение редактируемого элемента */

                TPeople People = Spisok_LB.SelectedItem as TPeople; /* Установка значений полей ввода
                диалогового окна в текущие значения редактируемого элемента */

                Dialog.FIO_TB.Text = People.FIO; Dialog.Series_TB.Text = People.Series; Dialog.Number_TB.Text = People.Number.ToString();
                /* Вызов диалогового окна и проверка результата завершения
                его работы. Если окно закрыто с подтверждением ввода
                данных, то выполнение действий по редактированию
                элемента */

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    /* Изменение свойств редактируемого элемента */
                    People.FIO = Dialog.FIO_TB.Text.Trim(); People.Series = Dialog.Series_TB.Text.Trim();

                    People.Number = Convert.ToInt32(Dialog.Number_TB.Text); /* Изменение строки в списке
                    за счет изменения объекта, связанного со строкой */
                    Spisok_LB.Items[Spisok_LB.SelectedIndex] = People;
                }
            }
            else
                /* Если элемент не выбран, то вывод сообщения */
                MessageBox.Show("Не выбран элемент в списке", "Информация");
        }
        private void Del_B_Click(object sender, EventArgs e)
        {
            /* Проверка, выбран ли элемент для удаления */
            if (Spisok_LB.SelectedIndex != -1)

                /* Удаление строки из списка */
                Spisok_LB.Items.RemoveAt(Spisok_LB.SelectedIndex);
            else

                /* Если элемент не выбран, то вывод сообщения */
                MessageBox.Show("Не выбран элемент в списке", "Информация");
        }
    }
}
//BY TUSTUGASHEV Y.V.