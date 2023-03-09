// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array(int size, int x, int y)
{
    int[] array=new int[size];
    Random rand=new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=rand.Next(x,y);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(", ", array) + "]");
}

int[] myArray=Array(8,1,100);
PrintArray(myArray);