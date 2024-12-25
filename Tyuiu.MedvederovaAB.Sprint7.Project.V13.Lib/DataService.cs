using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MedvederovaAB.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        //Этот метод сортирует строки массива по значениям в четвёртом столбце.

        public object[,] SquareSort(object[,] data)
        {
            // Получаем количество строк в массиве
            int rows = data.GetLength(0);
            // Получаем количество столбцов в массиве
            int columns = data.GetLength(1);

            // Клонируем исходный массив, чтобы не изменять его
            object[,] sortedArray = (object[,])data.Clone();

            // Внешний цикл для прохода по всем строкам массива
            for (int i = 0; i < rows - 1; i++)
            {
                // Внутренний цикл для сортировки текущей строки с последующими
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения в четвёртом столбце (индекс 3)
                    if (Convert.ToInt32(sortedArray[j, 3]) > Convert.ToInt32(sortedArray[j + 1, 3]))
                    {
                        // Цикл для обмена строками
                        for (int k = 0; k < columns; k++)
                        {
                            // Временная переменная для хранения текущего элемента
                            object temp = sortedArray[j, k];
                            // Меняем местами элементы
                            sortedArray[j, k] = sortedArray[j + 1, k];
                            sortedArray[j + 1, k] = temp;
                        }
                    }
                }
            }
            // Возвращаем отсортированный массив
            return sortedArray;
        }

        // Метод для сортировки по значениям в третьем столбце.
        public object[,] PopulationSort(object[,] data)
        {
            // Получаем количество строк в массиве
            int rows = data.GetLength(0);
            // Получаем количество столбцов в массиве
            int columns = data.GetLength(1);

            // Клонируем исходный массив, чтобы не изменять его
            object[,] sortedArray = (object[,])data.Clone();

            // Внешний цикл для прохода по всем строкам массива
            for (int i = 0; i < rows - 1; i++)
            {
                // Внутренний цикл для сортировки текущей строки с последующими
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения в третьем столбце (индекс 2)
                    if (Convert.ToInt32(sortedArray[j, 2]) > Convert.ToInt32(sortedArray[j + 1, 2]))
                    {
                        // Цикл для обмена строками
                        for (int k = 0; k < columns; k++)
                        {
                            // Временная переменная для хранения текущего элемента
                            object temp = sortedArray[j, k];
                            // Меняем местами элементы
                            sortedArray[j, k] = sortedArray[j + 1, k];
                            sortedArray[j + 1, k] = temp;
                        }
                    }
                }
            }
            // Возвращаем отсортированный массив
            return sortedArray;
        }

        // Находит целевой элемент и возвращает все элементы из строки, в которой был найден целевой элемент.
        public string[] Search(object[,] data, string targetElement)
        {
            // Флаг для отслеживания наличия целевого элемента
            bool isElementFound = false;
            // Получаем количество строк и столбцов
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);
            // Инициализируем координаты целевого элемента
            int targetRow = -1;
            int targetColumn = -1;

            // Цикл для поиска целевого элемента
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем, равен ли текущий элемент искомому элементу
                    if (data[i, j].Equals(targetElement))
                    {
                        isElementFound = true; // Устанавливаем флаг
                        targetRow = i; // Запоминаем индекс строки
                        targetColumn = j; // Запоминаем индекс столбца
                        break; // Выходим из внутреннего цикла
                    }
                }
                if (isElementFound) // Если элемент найден, выходим из внешнего цикла
                {
                    break;
                }
            }

            // Создаем массив для результата
            string[] result = new string[columns];
            if (isElementFound) // Если элемент был найден
            {
                // Заполняем результат элементами из найденной строки
                for (int j = 0; j < columns; j++)
                {
                    result[j] = data[targetRow, j].ToString(); // Конвертируем каждый элемент в строку
                }
            }
            else // Если элемент не найден
            {
                // Заполняем результат пустыми строками
                for (int j = 0; j < columns; j++)
                {
                    result[j] = string.Empty; // Устанавливаем пустые значения
                }
            }

            // Возвращаем массив с результатами
            return result;
        
        }

        // Вычисляет сумму, минимум, максимум или среднее значение заданного столбца.
        public double DataStatistics(object[,] data, string commandStat, int column)
        {
            // Получаем количество строк и столбцов
            int numRows = data.GetLength(0);
            int numColumns = data.GetLength(1);

            double result = 0; // Инициализируем переменную результата
            if (commandStat == "sum") // Если команда - сумма
            {
                // Находим сумму значений в заданном столбце
                for (int i = 0; i < numRows; i++)
                {
                    result += Convert.ToInt32(data[i, column]); // Суммируем значения
                }
            }

            // Список для хранения значений
            List<int> termsList = new List<int>();
            if (commandStat == "min") // Если команда - минимальное значение
            {
                // Добавляем значения в список
                for (int i = 0; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                // Находим минимальное значение
                result = Convert.ToDouble(termsList.Min());
            }

            if (commandStat == "max") // Если команда - максимальное значение
            {
                // Добавляем значения в список
                for (int i = 0; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                // Находим максимальное значение
                result = Convert.ToDouble(termsList.Max());
            }

            if (commandStat == "average") // Если команда - среднее значение
            {
                double resSum = 0; // Инициализируем переменную для суммы
                for (int i = 0; i < numRows; i++)
                {
                    resSum += Convert.ToDouble(data[i, column]); // Суммируем значения
                }
                result = resSum / numRows; // Находим среднее
                result = Math.Round(result, 2); // Округляем до 2 знаков после запятой
            }

            // Возвращаем результат
            return result;
        }
    }
}
