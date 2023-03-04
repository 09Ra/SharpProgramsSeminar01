// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputСolumnRow(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Array(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");

        }
        System.Console.WriteLine();
    }

}

void Average(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        double result2 = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];

        }
        result2 = Math.Round(result / array.GetLength(0), 1);
        System.Console.Write(result2 + "     ");

    }
}


int m = InputСolumnRow("Введите количество строк матрицы: ");
int n = InputСolumnRow("Введите количество столбцов матрицы: ");
int[,] myArray = Array(m, n);
PrintMatrix(myArray);
System.Console.WriteLine();
Average(myArray);