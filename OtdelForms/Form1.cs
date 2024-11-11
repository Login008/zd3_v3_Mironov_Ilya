using OtdelLibrary;

namespace OtdelForms
{
    public partial class Form1 : Form
    {
        Otdel otdelM = new Otdel("", 2, 2, 2, ""); //������ ��� ������ ������� GetInfo, ���� ������������ ����������� ����� ��������
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ContextMenuStrip = contextMenuStrip1; //�������� ���� � �������
            dataGridView2.ContextMenuStrip = contextMenuStrip2;
        }
        public static void GetOtdelInGrid(DataGridView grid, List<string[]> list) //��������� ��� ������ ���������� �� ������� � �������
        {
            grid.Columns.Clear(); //������� �������� � ����� �������
            grid.Rows.Clear();

            grid.Columns.Add("�����", "�����"); //���������� ��������
            grid.Columns.Add("������� �����", "������� �����");
            grid.Columns.Add("����������", "����������");
            grid.Columns.Add("���-�� �����������", "���-�� �����������");
            grid.Columns.Add("��������", "��������");

            foreach (var item in list) //������� �������� � ������ � ���������� �� � �������
            {
                grid.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }
        public static void GetHR_OtdelInGrid(DataGridView grid, List<string[]> list) //��������� ��� ������ ���������� �� HR-������� � �������
        {
            grid.Columns.Clear(); //�� �� �� �����, ������ ��� ������ HR-������
            grid.Rows.Clear();

            grid.Columns.Add("�����", "�����");
            grid.Columns.Add("������� �����", "������� �����");
            grid.Columns.Add("����������", "����������");
            grid.Columns.Add("���-�� �����������", "���-�� �����������");
            grid.Columns.Add("��������", "��������");
            grid.Columns.Add("���������", "���������");
            grid.Columns.Add("�������������", "�������������");
            grid.Columns.Add("���. ��������", "���. ��������");
            grid.Columns.Add("���. ��������", "���. ��������");

            foreach (var item in list)
            {
                grid.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8]);
            }
        }

        private void AddOtdel(object sender, EventArgs e) //����� ������ ����� ��� ����������
        {
            AddOtdelForm f1 = new AddOtdelForm(dataGridView1);
            f1.Show();
        }

        private void RemoveOtdel(object sender, EventArgs e) //�������� 1-�� �����������
        {
            if (dataGridView1.SelectedRows.Count == 1) //�������� �� ���� ���������� ������
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null) //�������� �� ������� ������
                {
                    string[] data = new string[dataGridView1.ColumnCount];
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        data[i] = dataGridView1.SelectedRows[0].Cells[i].Value.ToString(); //������� ������ �� ������� � ������
                    }

                    Otdel.RemoveOtdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //1-�� ����������
                    MessageBox.Show("����� ������� �����");

                    GetOtdelInGrid(dataGridView1, otdelM.GetInfo()); //����� ������ ������� � �������
                }
                else
                    MessageBox.Show("�������� �� ������� ������");
            }
            else
            {
                MessageBox.Show("�������� ���� ������");
            }
        }

        private void RemoveOtdel2(object sender, EventArgs e) //�������� 2-�� �����������
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

                    Otdel otdel = new Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //2-�� ����������
                    Otdel.RemoveOtdel(otdel);
                    MessageBox.Show("����� ������� �����");

                    GetOtdelInGrid(dataGridView1, otdelM.GetInfo());
                }
                else
                    MessageBox.Show("�������� �� ������� ������");
            }
            else
            {
                MessageBox.Show("�������� ���� ������");
            }
        }

        private void RemoveOtdel3(object sender, EventArgs e) //�������� 3-�� �����������
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

                    Otdel otdel = new Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //3-� ����������
                    otdel.RemoveOtdel();
                    MessageBox.Show("����� ������� �����");

                    GetOtdelInGrid(dataGridView1, otdelM.GetInfo());
                }
                else
                    MessageBox.Show("�������� �� ������� ������");
            }
            else
            {
                MessageBox.Show("�������� ���� ������");
            }
        }

        private void GetQ(object sender, EventArgs e) //���������� �������� ������
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

                    Otdel otdel = new Otdel(data[0], double.Parse(data[1]), double.Parse(data[2]), int.Parse(data[3]), data[4]); //�������� �������
                    MessageBox.Show($"�������� ������� ������ = {otdel.GetQ()}"); //����� �������� ������ ����������
                }
                else
                    MessageBox.Show("�������� �� ������� ������");
            }
            else
            {
                MessageBox.Show("�������� ���� ������");
            }
        }

        private void Addition(object sender, EventArgs e) //����� ����� ��� ���������� HR-������
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
                    otdel.RemoveOtdel(); //�������� ������ �� �������
                    MessageBox.Show("����� ������� �����");

                    GetHR_OtdelInGrid(dataGridView2, otdel.GetInfo());
                }
                else
                    MessageBox.Show("�������� �� ������� ������");
            }
            else
            {
                MessageBox.Show("�������� ���� ������");
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
                    MessageBox.Show($"�������� ������� ������ = {otdel.GetQ()}"); //����� �������� HR-������ ����������
                }
                else
                    MessageBox.Show("�������� �� ������� ������");
            }
            else
            {
                MessageBox.Show("�������� ���� ������");
            }
        }

        private void Search(object sender, EventArgs e)
        {
            try //�������� �� �������� �����
            {
                if (textBox1.Text != "") //�������� �� ������ ����
                {
                    IEnumerable<string> list = HR_Otdel.GetPValue(double.Parse(textBox1.Text)); //�������� ������ ������� � ���������� �� ����
                    if (list.Count() != 0)
                    {
                        string message = "";
                        foreach (var item in list) //���������� ������
                        {
                            message += item + "\n"; //���������� � ���� ���������
                        }
                        MessageBox.Show(message); //����� �� �����
                    }
                    else
                        MessageBox.Show("������� � ����� ���������� �� ���� �������");
                }
                else
                    MessageBox.Show("��������� ����");
            }
            catch
            {
                MessageBox.Show("������� �����");
            }
        }
    }
}
