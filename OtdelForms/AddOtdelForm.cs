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

namespace OtdelForms
{
    public partial class AddOtdelForm : Form
    {
        DataGridView grid;
        public AddOtdelForm(DataGridView d1)
        {
            InitializeComponent();
            grid = d1; //получаем переданную в форму таблицу и присваиваем глобальной переменной
        }

        private void AddOtdel(object sender, EventArgs e)
        {
            try //Проверка на тип данных и адекватность значений
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    Otdel otdel = new Otdel(textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text), int.Parse(textBox4.Text),
                    textBox5.Text); //Создаём объект
                    otdel.AddOtdel(); //Добавляем в список
                    Form1.GetOtdelInGrid(grid, otdel.GetInfo()); //Вывод списка отделов в таблицу
                    this.Close(); //Закрываем форму
                }
                else
                    MessageBox.Show("Заполните пустые поля");
            }
            catch
            {
                MessageBox.Show("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n\nИли точно такой же отдел уже есть в таблице");
            }
        }

        private void AddOtdel2(object sender, EventArgs e)
        {
            try //Проверка на тип данных и адекватность значений
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    Otdel otdel = new Otdel("", 2, 2, 2, ""); //Создаём объект для вызова вывода инфорации в таблицу
                Otdel.AddOtdel(textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text), int.Parse(textBox4.Text),
                textBox5.Text); //Добавляем в список
                Form1.GetOtdelInGrid(grid, otdel.GetInfo()); //Вывод списка отделов в таблицу
                this.Close(); //Закрываем форму
                }
                else
                    MessageBox.Show("Заполните пустые поля");
            }
            catch
            {
                MessageBox.Show("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n\nИли точно такой же отдел уже есть в таблице");
            }
        }

        private void AddOtdel3(object sender, EventArgs e)
        {
            try //Проверка на тип данных и адекватность значений
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    Otdel otdel = new Otdel(textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text), int.Parse(textBox4.Text),
                textBox5.Text); //Создаём объект
                Otdel.AddOtdel(otdel); //Добавляем в список
                Form1.GetOtdelInGrid(grid, otdel.GetInfo()); //Вывод списка отделов в таблицу
                this.Close(); //Закрываем форму
                }
                else
                    MessageBox.Show("Заполните пустые поля");
            }
            catch
            {
                MessageBox.Show("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n\nИли точно такой же отдел уже есть в таблице");
            }
        }
    }
}
