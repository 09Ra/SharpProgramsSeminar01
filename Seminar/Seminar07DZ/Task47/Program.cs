// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

//0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int InputСolumnRow (string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Array(int m, int n)
{
    double[,] array=new double[m,n];
    Random rand=new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           array[i,j]=rand.Next(0,10)+Math.Round(rand.NextDouble(),1); 
        }
    }
    return array;
}

void PrintMatrix(double[,] matrix)
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


int m=InputСolumnRow("Введите количество строк матрицы: ");
int n=InputСolumnRow("Введите количество столбцов матрицы: ");
double[,] myArray=Array(m,n);
PrintMatrix(myArray);