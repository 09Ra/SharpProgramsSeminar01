/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
            array[i, j] = rand.Next(0, 100);
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

int[,] ChangeMatrix(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {

                if (array[i, x] < array[i, x + 1])
                {
                    temp = array[i, x];
                    array[i, x] = array[i, x + 1];
                    array[i, x+ 1] = temp;
                }
            }
        }

    }
    return array;
}
int m = InputСolumnRow("Введите количество строк матрицы: ");
int n = InputСolumnRow("Введите количество столбцов матрицы: ");
int[,] myArray = Array(m, n);
PrintMatrix(myArray);
System.Console.WriteLine();
int[,] myArray2 = ChangeMatrix(myArray);
PrintMatrix(myArray2);
