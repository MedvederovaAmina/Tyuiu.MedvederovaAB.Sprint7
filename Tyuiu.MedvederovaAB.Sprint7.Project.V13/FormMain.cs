using System.Text;
using Tyuiu.MedvederovaAB.Sprint7.Project.V13.Lib;

namespace Tyuiu.MedvederovaAB.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogLibrary_MAB.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogLibrary_MAB.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string OpenFilePath;

        DataService ds = new DataService();

        // Метод для загрузки данных из CSV файла в двумерный массив
        public static object[,] LoadFromFileData(string filePath)
        {
            // Чтение всех данных из файла
            string fileData = File.ReadAllText(filePath);

            // Заменяем символы новой строки для обработки
            fileData = fileData.Replace('\n', '\r');
            // Разделяем строки по символу возврата 
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length; // Получаем количество строк
            int columns = lines[0].Split(';').Length; // Получаем количество столбцов по первой строке (разделяем точкой с запятой)

            // Создаем двумерный массив для хранения значений
            object[,] arrayValues = new object[rows, columns];

            // Заполняем массив данными из файла
            for (int r = 0; r < rows; r++)
            {
                // Разделяем строку на отдельные значения
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    // Преобразуем значение в строку и записываем в массив
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues; // Возвращаем заполненный массив
        }

        private void labelResStatistic_MAB_Click(object sender, EventArgs e)
        {

        }
        // Обработчик события щелчка на кнопке "Открыть файл"
        private void buttonOpenFile_MAB_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно для выбора файла
            openFileDialogLibrary_MAB.ShowDialog();
            OpenFilePath = openFileDialogLibrary_MAB.FileName; // Получаем путь к выбранному файлу

            // Проверяем, существует ли файл
            if (!File.Exists(OpenFilePath))
            {
                MessageBox.Show("Файл не найден или не выбран", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Если файл не существует, выходим из метода
            }

            object[,] arrayValues = new object[rows, columns];

            // Загружаем данные из файла в массив
            arrayValues = LoadFromFileData(OpenFilePath);

            // Устанавливаем количество строк и столбцов в DataGridView
            dataGridViewInPutData_MAB.ColumnCount = columns;
            dataGridViewInPutData_MAB.RowCount = rows;

            dataGridViewOutPutData_MAB.ColumnCount = columns;
            dataGridViewOutPutData_MAB.RowCount = rows;

            // Устанавливаем ширину столбцов в DataGridView
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_MAB.Columns[i].Width = 100; // Устанавливаем ширину в 100 пикселей
                dataGridViewOutPutData_MAB.Columns[i].Width = 100;
            }

            // Заполняем DataGridView значениями из массива
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_MAB.Rows[r].Cells[c].Value = arrayValues[r, c]; // Записываем данные в ячейки
                }
            }
        }
        // Обработчик события щелчка на кнопке "Сортировать по площади"
        private void buttonSortSquare_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                // Загружаем данные, сортируем и обновляем диаграмму
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.SquareSort(LoadFromFileData(filePath: OpenFilePath)); // Проводим сортировку

                // Настраиваем график
                chartStatistic_MAB.ChartAreas[0].AxisX.Title = "Страна";
                chartStatistic_MAB.ChartAreas[0].AxisY.Title = "Площадь";

                chartStatistic_MAB.Series[0].Points.Clear(); // Очищаем предыдущие данные на графике

                // Обновляем DataGridView и диаграмму
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutData_MAB.Rows[r].Cells[c].Value = arrayValues[r, c]; // Заполняем ячейки значениями
                    }
                    // Добавляем новые данные на график
                    chartStatistic_MAB.Series[0].Points.AddXY(r, arrayValues[r, 3]); // Предполагается, что индекс 3 - это площадь
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события щелчка на кнопке "Сортировать по населению"
        private void buttonSortPopulation_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.PopulationSort(LoadFromFileData(filePath: OpenFilePath)); // Проводим сортировку

                // Настройка графика
                chartStatistic_MAB.ChartAreas[0].AxisX.Title = "Страна";
                chartStatistic_MAB.ChartAreas[0].AxisY.Title = "Население";

                chartStatistic_MAB.Series[0].Points.Clear(); // Очищаем предыдущие данные на графике

                // Обновляем DataGridView и диаграмму
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutPutData_MAB.Rows[r].Cells[c].Value = arrayValues[r, c]; // Заполняем ячейки значениями
                    }
                    // Добавляем новые данные на график
                    chartStatistic_MAB.Series[0].Points.AddXY(r, arrayValues[r, 2]); // Предполагается, что индекс 2 - это население
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Обработчик события щелчка на кнопке "Поиск информации"
        private void buttonSearchInfo_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_MAB.Text); // Получаем искомый элемент

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(filePath: OpenFilePath), targetElement); // Ищем в массиве

                // Очищаем значения в результирующем DataGridView
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutPutData_MAB.Rows[i].Cells[j].Value = null; // Устанавливаем пустые значения
                    }
                }
                // Заполняем первой строкой найденные значения
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_MAB.Rows[0].Cells[c].Value = arrayValues[c]; // Запись найденной строки
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Обработчик события щелчка на кнопке "Статистика"
        private void buttonStatistic_MAB_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = Convert.ToString(textBoxOperation_MAB.Text); // Получаем нужную команду
                int columnIndex = Convert.ToInt32(textBoxNumOfColumn_MAB.Text) - 1; // Получаем индекс столбца (с учетом смещения)

                object[,] dataBase = LoadFromFileData(filePath: OpenFilePath); // Загружаем данные

                // Вычисляем статистику и выводим результат
                textBoxResStatistic_MAB.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Обработчик события щелчка на кнопке "Сохранить файл"
        private void buttonSaveFile_MAB_Click(object sender, EventArgs e)
        {
            saveFileDialogLibrary_MAB.FileName = "OutPutFileProjectV13.csv"; // Имя файла по умолчанию
            saveFileDialogLibrary_MAB.InitialDirectory = Directory.GetCurrentDirectory(); // Устанавливаем начальный путь
            saveFileDialogLibrary_MAB.ShowDialog(); // Показать диалог сохранения

            string path = saveFileDialogLibrary_MAB.FileName; // Получаем путь сохранения

            // Удаляем файл, если он уже существует
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Получаем количество строк и столбцов в результирующем DataGridView
            int rows = dataGridViewOutPutData_MAB.RowCount;
            int columns = dataGridViewOutPutData_MAB.ColumnCount;
            string str = "";

            // Запись данных из DataGridView в файл
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Добавляем значения в строку, разделяя их символом ';'
                    str += dataGridViewOutPutData_MAB.Rows[i].Cells[j].Value + (j != columns - 1 ? ";" : "");
                }
                File.AppendAllText(path, str + Environment.NewLine); // Записываем строку в файл
                str = ""; // Обнуляем строку для следующей записи
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
