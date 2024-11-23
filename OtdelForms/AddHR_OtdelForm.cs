using OtdelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtdelForms
{
    public partial class AddHR_OtdelForm : Form
    {
        DataGridView grid;
        public AddHR_OtdelForm(DataGridView d1)
        {
            InitializeComponent();
            grid = d1; //получаем переданную в форму таблицу и присваиваем глобальной переменной
        }

        private void Add(object sender, EventArgs e)
        {
            try //Проверка на тип данных и адекватность значений
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                    textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                {
                    HR_Otdel otdel = new HR_Otdel(textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text), int.Parse(textBox4.Text),
                    textBox5.Text, double.Parse(textBox6.Text), textBox7.Text, textBox8.Text, textBox9.Text); //Создаём объект
                    otdel.AddOtdel(); //Добавляем в словарь
                    Form1.GetHR_OtdelInGrid(grid, otdel.GetInfo()); //Выводим информацию в таблицу
                    this.Close(); //Закрываем форму
                }
                else
                    MessageBox.Show("Заполните пустые поля");
            }
            catch
            {
                MessageBox.Show("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n0 <= Вредность <= 3\n\n" +
                    "Или точно такой же отдел уже есть в таблице");
            }
        }
    }
}
