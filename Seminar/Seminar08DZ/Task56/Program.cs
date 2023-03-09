/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int[] Sum (int[,] array, int m)
{
    int[] sumArray=new int[m];
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
                        
        }
        sumArray[i]=sum;
        System.Console.WriteLine(sumArray[i] +"      ");
    }
return sumArray;
}

void MinSum(int[] array, int m)
{
   int min = array[0];
    int minIndex=0;  
 for (int i = 0; i < m; i++)

 {
    while (array[i]<min)
    {
        
        min=array[i];
        minIndex=i;
        
    }
    
 }
 System.Console.WriteLine("Строка с индексом "+minIndex+ " с суммой элементов " +min+ " является строкой с наименьшей суммой элементов");
 System.Console.WriteLine();
}


int m = InputСolumnRow("Введите количество строк и столбцов матрицы: ");
int[,] myArray = Array(m, m);
PrintMatrix(myArray);
System.Console.WriteLine();
int [] array=Sum(myArray,m);
System.Console.WriteLine();
MinSum(array,m);


