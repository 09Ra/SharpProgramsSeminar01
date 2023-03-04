// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputСolumnRow (string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Array(int m, int n)
{
    int[,] array=new int [m,n];
    Random rand=new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           array[i,j]=rand.Next(0,10); 
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

void Element(int[,] array, int i, int j)
{
    if (i<array.GetLength(0) && j<array.GetLength(1))
    {
        System.Console.WriteLine(array[i,j]);
    }
    else
    {
        System.Console.WriteLine("Такого элемента в матрице нет");
    }
}



int m=InputСolumnRow("Введите количество строк матрицы: ");
int n=InputСolumnRow("Введите количество столбцов матрицы: ");
int i=InputСolumnRow("Строка позиции элемента: ");
int j=InputСolumnRow("Столбец позиции элемента: ");
int[,] myArray=Array(m,n);
PrintMatrix(myArray);
Element(myArray,i,j);