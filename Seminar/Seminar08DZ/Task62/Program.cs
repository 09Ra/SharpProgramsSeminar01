/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


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
            array[i, j] = rand.Next(0, 1);
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

void FillingMatrix(int[,] array, int size)
{
    int i = 0;
    int j = 0;
    int number = 1;

    for (int r = 1; r < size; r++)
    {

        if (array[r - 1, j + r] == 0)
        {

            for (int k = 0; k < size; k++)
            {
                while (array[r - 1, j + k] == 0)
                {
                    array[r - 1, j + k] = number;
                    number++;
                }
            }
        }

        if (array[i + r, size - r] == 0)
        {
            for (int c = 1; c < size; c++)
            {
                while (array[i + c, size - r] == 0)
                {
                    array[i + c, size - r] = number;
                    number++;
                }
            }
        }

        if (array[size - r, size - r - 1] == 0)
        {
            for (int x = 2; x <= size; x++)
            {
                while (array[size - r, size - x] == 0)
                {
                    array[size - r, size - x] = number;
                    number++;
                }
            }
        }

        if (array[size - r - 1, r - 1] == 0)
        {
            for (int y = 1; y < size; y++)
            {
                while (array[size - y, r - 1] == 0)
                {
                    array[size - y, r - 1] = number;
                    number++;
                }
            }
        }
    }
}

int a = InputСolumnRow("Введите количество строк столбцов и строк матрицы:  ");

int[,] myArray = Array(a, a);

FillingMatrix(myArray, a);
PrintMatrix(myArray);
System.Console.WriteLine();




