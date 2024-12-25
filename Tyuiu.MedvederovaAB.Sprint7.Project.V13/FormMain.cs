using System.Text;
using Tyuiu.MedvederovaAB.Sprint7.Project.V13.Lib;

namespace Tyuiu.MedvederovaAB.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogLibrary_MAB.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialogLibrary_MAB.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string OpenFilePath;

        DataService ds = new DataService();

        // ����� ��� �������� ������ �� CSV ����� � ��������� ������
        public static object[,] LoadFromFileData(string filePath)
        {
            // ������ ���� ������ �� �����
            string fileData = File.ReadAllText(filePath);

            // �������� ������� ����� ������ ��� ���������
            fileData = fileData.Replace('\n', '\r');
            // ��������� ������ �� ������� �������� 
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length; // �������� ���������� �����
            int columns = lines[0].Split(';').Length; // �������� ���������� �������� �� ������ ������ (��������� ������ � �������)

            // ������� ��������� ������ ��� �������� ��������
            object[,] arrayValues = new object[rows, columns];

            // ��������� ������ ������� �� �����
            for (int r = 0; r < rows; r++)
            {
                // ��������� ������ �� ��������� ��������
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    // ����������� �������� � ������ � ���������� � ������
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues; // ���������� ����������� ������
        }

        private void labelResStatistic_MAB_Click(object sender, EventArgs e)
        {

        }
        // ���������� ������� ������ �� ������ "������� ����"
        private void buttonOpenFile_MAB_Click(object sender, EventArgs e)
        {
            // ��������� ���������� ���� ��� ������ �����
            openFileDialogLibrary_MAB.ShowDialog();
            OpenFilePath = openFileDialogLibrary_MAB.FileName; // �������� ���� � ���������� �����

            // ���������, ���������� �� ����
            if (!File.Exists(OpenFilePath))
            {
                MessageBox.Show("���� �� ������ ��� �� ������", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ���� ���� �� ����������, ������� �� ������
            }

            object[,] arrayValues = new object[rows, columns];

            // ��������� ������ �� ����� � ������
            arrayValues = LoadFromFileData(OpenFilePath);

            // ������������� ���������� ����� � �������� � DataGridView
            dataGridViewInPutData_MAB.ColumnCount = columns;
            dataGridViewInPutData_MAB.RowCount = rows;

            dataGridViewOutPutData_MAB.ColumnCount = columns;
            dataGridViewOutPutData_MAB.RowCount = rows;

            // ������������� ������ �������� � DataGridView
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_MAB.Columns[i].Width = 100; // ������������� ������ � 100 ��������
                dataGridViewOutPutData_MAB.Columns[i].Width = 100;
            }

            // ��������� DataGridView ���������� �� �������
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_MAB.Rows[r].Cells[c].Value = arrayValues[r, c]; // ���������� ������ � ������
                }
            }
        }
        // ���������� ������� ������ �� ������ "����������� �� �������"
        private void buttonSortSquare_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                // ��������� ������, ��������� � ��������� ���������
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.SquareSort(LoadFromFileData(filePath: OpenFilePath)); // �������� ����������

                // ����������� ������
                chartStatistic_MAB.ChartAreas[0].AxisX.Title = "������";
                chartStatistic_MAB.ChartAreas[0].AxisY.Title = "�������";

                chartStatistic_MAB.Series[0].Points.Clear(); // ������� ���������� ������ �� �������

                // ��������� DataGridView � ���������
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutData_MAB.Rows[r].Cells[c].Value = arrayValues[r, c]; // ��������� ������ ����������
                    }
                    // ��������� ����� ������ �� ������
                    chartStatistic_MAB.Series[0].Points.AddXY(r, arrayValues[r, 3]); // ��������������, ��� ������ 3 - ��� �������
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ������� ������ �� ������ "����������� �� ���������"
        private void buttonSortPopulation_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.PopulationSort(LoadFromFileData(filePath: OpenFilePath)); // �������� ����������

                // ��������� �������
                chartStatistic_MAB.ChartAreas[0].AxisX.Title = "������";
                chartStatistic_MAB.ChartAreas[0].AxisY.Title = "���������";

                chartStatistic_MAB.Series[0].Points.Clear(); // ������� ���������� ������ �� �������

                // ��������� DataGridView � ���������
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutData_MAB.Rows[r].Cells[c].Value = arrayValues[r, c]; // ��������� ������ ����������
                    }
                    // ��������� ����� ������ �� ������
                    chartStatistic_MAB.Series[0].Points.AddXY(r, arrayValues[r, 2]); // ��������������, ��� ������ 2 - ��� ���������
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ���������� ������� ������ �� ������ "����� ����������"
        private void buttonSearchInfo_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_MAB.Text); // �������� ������� �������

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(filePath: OpenFilePath), targetElement); // ���� � �������

                // ������� �������� � �������������� DataGridView
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutPutData_MAB.Rows[i].Cells[j].Value = null; // ������������� ������ ��������
                    }
                }
                // ��������� ������ ������� ��������� ��������
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_MAB.Rows[0].Cells[c].Value = arrayValues[c]; // ������ ��������� ������
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ���������� ������� ������ �� ������ "����������"
        private void buttonStatistic_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = Convert.ToString(textBoxOperation_MAB.Text); // �������� ������ �������
                int columnIndex = Convert.ToInt32(textBoxNumOfColumn_MAB.Text) - 1; // �������� ������ ������� (� ������ ��������)

                object[,] dataBase = LoadFromFileData(filePath: OpenFilePath); // ��������� ������

                // ��������� ���������� � ������� ���������
                textBoxResStatistic_MAB.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ���������� ������� ������ �� ������ "��������� ����"
        private void buttonSaveFile_MAB_Click(object sender, EventArgs e)
        {
            saveFileDialogLibrary_MAB.FileName = "OutPutFileProjectV13.csv"; // ��� ����� �� ���������
            saveFileDialogLibrary_MAB.InitialDirectory = Directory.GetCurrentDirectory(); // ������������� ��������� ����
            saveFileDialogLibrary_MAB.ShowDialog(); // �������� ������ ����������

            string path = saveFileDialogLibrary_MAB.FileName; // �������� ���� ����������

            // ������� ����, ���� �� ��� ����������
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // �������� ���������� ����� � �������� � �������������� DataGridView
            int rows = dataGridViewOutPutData_MAB.RowCount;
            int columns = dataGridViewOutPutData_MAB.ColumnCount;
            string str = "";

            // ������ ������ �� DataGridView � ����
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // ��������� �������� � ������, �������� �� �������� ';'
                    str += dataGridViewOutPutData_MAB.Rows[i].Cells[j].Value + (j != columns - 1 ? ";" : "");
                }
                File.AppendAllText(path, str + Environment.NewLine); // ���������� ������ � ����
                str = ""; // �������� ������ ��� ��������� ������
            }
        }

        private void buttonInfo_MAB_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonTask_MAB_Click(object sender, EventArgs e)
        {
            FormTask formTask = new FormTask();
            formTask.ShowDialog();
        }

        private void groupBoxOperation_MAB_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuide_MAB_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
    }
}
