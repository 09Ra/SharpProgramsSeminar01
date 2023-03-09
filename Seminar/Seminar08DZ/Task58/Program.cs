/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] Product(int[,] array1, int[,] array2, int a, int b, int c, int d)
{
    int[,] productArray = new int[a, d];
    if ((b == c))
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < d; j++)
            {
                int sum = 0;
                for (int x = 0; x < b; x++)
                {
                    sum += array1[i, x] * array2[x, j];
                }

                productArray[i, j] = sum;
            }
        }
    }
    else
    {
        Console.WriteLine("количество столбцов первой матрицы не равно количеству строк второй матрицы");
    }
    return productArray;
}

int a = InputСolumnRow("Введите количество строк первой матрицы:  ");
int b = InputСolumnRow("Введите количество столбцов первой матрицы:  ");
int c = InputСolumnRow("Введите количество строк второй матрицы:  ");
int d = InputСolumnRow("Введите количество столбцов второй матрицы:  ");
int[,] arrayOne = Array(a, b);
int[,] arrayTwo = Array(c, d);
PrintMatrix(arrayOne);
System.Console.WriteLine();
PrintMatrix(arrayTwo);
System.Console.WriteLine();
int[,] productArray = Product(arrayOne, arrayTwo, a, b, c, d);
PrintMatrix(productArray);
System.Console.WriteLine();


