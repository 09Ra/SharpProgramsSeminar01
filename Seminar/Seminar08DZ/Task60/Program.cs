/* Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int InputСolumnRow(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] Array(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int c = 0; c < z; c++)
            {
                array[i, j, c] = rand.Next(10, 100);
            }

        }
    }
    return array;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int c = 0; c < matrix.GetLength(2); c++)
            {
                System.Console.Write(matrix[i, j, c] + "(" + i + ", " + j + ", " + c + ")" + "\t");

            }
        }
        System.Console.WriteLine();
    }
}



int a = InputСolumnRow("Введите первое измерение массива:  ");
int b = InputСolumnRow("Введите второе измерение массива:  ");
int c = InputСolumnRow("Введите третье измерение массива:  ");
System.Console.WriteLine();
int[,,] arrayOne = Array(a, b, c);

PrintMatrix(arrayOne);
System.Console.WriteLine();




