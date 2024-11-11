using OtdelLibrary;

namespace OtdelForms
{
    public partial class Form1 : Form
    {
        Otdel otdelM = new Otdel("", 2, 2, 2, ""); //Объект для вызова функции GetInfo, если используется статический класс удаления
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ContextMenuStrip = contextMenuStrip1; //привязка меню к таблице
            dataGridView2.ContextMenuStrip = contextMenuStrip2;
        }
        public static void GetOtdelInGrid(DataGridView grid, List<string[]> list) //процедура для вывода информации об отделах в таблицу
        {
            grid.Columns.Clear(); //Очистка столбцов и строк таблицы
            grid.Rows.Clear();

            grid.Columns.Add("Отдел", "Отдел"); //Добавление столбцов
            grid.Columns.Add("Базовый оклад", "Базовый оклад");
            grid.Columns.Add("Коэффицент", "Коэффицент");
            grid.Columns.Add("Кол-во сотрудников", "Кол-во сотрудников");
            grid.Columns.Add("Компания", "Компания");

            foreach (var item in list) //перебор массивов в списке и добавление их в таблицу
            {
                grid.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }
        public static void GetHR_OtdelInGrid(DataGridView grid, List<string[]> list) //процедура для вывода информации об HR-отделах в таблицу
        {
            grid.Columns.Clear(); //Всё то же самое, только для вывода HR-отдела
            grid.Rows.Clear();

            grid.Columns.Add("Отдел", "Отдел");
            grid.Columns.Add("Базовый оклад", "Базовый оклад");
            grid.Columns.Add("Коэффицент", "Коэффицент");
            grid.Columns.Add("Кол-во сотрудников", "Кол-во сотрудников");
            grid.Columns.Add("Компания", "Компания");
            grid.Columns.Add("Вредность", "Вредность");
            grid.Columns.Add("Специальность", "Специальность");
            grid.Columns.Add("Ген. директор", "Ген. директор");
            grid.Columns.Add("Тех. директор", "Тех. директор");

            foreach (var item in list)
            {
                grid.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8]);
            }
        }

        private void AddOtdel(object sender, EventArgs e) //Вызов другой формы для добавления
        {
            AddOtdelForm f1 = new AddOtdelForm(dataGridView1);
            f1.Show();
        }

        private void RemoveOtdel(object sender, EventArgs e) //Удаление 1-ой перегрузкой
        {
            if (dataGridView1.SelectedRows.Count == 1) //Проверка на одну выделенную строку
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null) //Проверка на нулевую строку
                {
                    string[] data = new string[dataGridView1.ColumnCount];
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        data[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString(); //перенос данных из таблицы в массив
                    }

                    Otdel.RemoveOtdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //1-ая перегрузка
                    MessageBox.Show("Отдел успешно удалён");

                    GetOtdelInGrid(dataGridView1, otdelM.GetInfo()); //Вывод списка отделов в таблицу
                }
                else
                    MessageBox.Show("Выберите не нулевую строку");
            }
            else
            {
                MessageBox.Show("Выделите одну строку");
            }
        }

        private void RemoveOtdel2(object sender, EventArgs e) //Удаление 2-ой перегрузкой
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    string[] data = new string[dataGridView1.ColumnCount];
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        data[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                    }

                    Otdel otdel = new Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //2-ая перегрузка
                    Otdel.RemoveOtdel(otdel);
                    MessageBox.Show("Отдел успешно удалён");

                    GetOtdelInGrid(dataGridView1, otdelM.GetInfo());
                }
                else
                    MessageBox.Show("Выберите не нулевую строку");
            }
            else
            {
                MessageBox.Show("Выделите одну строку");
            }
        }

        private void RemoveOtdel3(object sender, EventArgs e) //Удаление 3-ей перегрузкой
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    string[] data = new string[dataGridView1.ColumnCount];
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        data[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                    }

                    Otdel otdel = new Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //3-я перегрузка
                    otdel.RemoveOtdel();
                    MessageBox.Show("Отдел успешно удалён");

                    GetOtdelInGrid(dataGridView1, otdelM.GetInfo());
                }
                else
                    MessageBox.Show("Выберите не нулевую строку");
            }
            else
            {
                MessageBox.Show("Выделите одну строку");
            }
        }

        private void GetQ(object sender, EventArgs e) //Вычисление качества отдела
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    string[] data = new string[dataGridView1.ColumnCount];
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        data[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                    }

                    Otdel otdel = new Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //создание объекта
                    MessageBox.Show($"Качество данного отдела = {otdel.GetQ()}"); //вывод качества отдела сообщением
                }
                else
                    MessageBox.Show("Выберите не нулевую строку");
            }
            else
            {
                MessageBox.Show("Выделите одну строку");
            }
        }

        private void Addition(object sender, EventArgs e) //Вызов формы для добавления HR-отдела
        {
            AddHR_OtdelForm f1 = new AddHR_OtdelForm(dataGridView2);
            f1.Show();
        }

        private void RemoveHR(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value != null)
                {
                    string[] data = new string[dataGridView2.ColumnCount];
                    for (int i = 0; i < dataGridView2.ColumnCount; i++)
                    {
                        data[i] = dataGridView2.SelectedRows[0].Cells[i].Value.ToString();
                    }

                    HR_Otdel otdel = new HR_Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4],
                        double.Parse(data[5]), data[6], data[7], data[8]);
                    otdel.RemoveOtdel(); //удаление отдела из словаря
                    MessageBox.Show("Отдел успешно удалён");

                    GetHR_OtdelInGrid(dataGridView2, otdel.GetInfo());
                }
                else
                    MessageBox.Show("Выберите не нулевую строку");
            }
            else
            {
                MessageBox.Show("Выделите одну строку");
            }
        }

        private void GetQHR(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value != null)
                {
                    string[] data = new string[dataGridView2.ColumnCount];
                    for (int i = 0; i < dataGridView2.ColumnCount; i++)
                    {
                        data[i] = dataGridView2.SelectedRows[0].Cells[i].Value.ToString();
                    }

                    HR_Otdel otdel = new HR_Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4],
                        double.Parse(data[5]), data[6], data[7], data[8]);
                    MessageBox.Show($"Качество данного отдела = {otdel.GetQ()}"); //вывод качества HR-отдела сообщением
                }
                else
                    MessageBox.Show("Выберите не нулевую строку");
            }
            else
            {
                MessageBox.Show("Выделите одну строку");
            }
        }

        private void Search(object sender, EventArgs e)
        {
            try //проверка на введение числа
            {
                if (textBox1.Text != "") //проверка на пустое поле
                {
                    IEnumerable<string> list = HR_Otdel.GetPValue(double.Parse(textBox1.Text)); //Получаем список отделов с вредностью из поля
                    if (list.Count() != 0)
                    {
                        string message = "";
                        foreach (var item in list) //перебираем список
                        {
                            message += item + "\n"; //объединяем в одно сообщение
                        }
                        MessageBox.Show(message); //вывод на экран
                    }
                    else
                        MessageBox.Show("Отделов с такой вредностью не было найдено");
                }
                else
                    MessageBox.Show("Заполните поле");
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }
    }
}
