// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int size)
{
    int[] array= new int[size];
    Random rand=new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rand.Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(", ",array)+"]");
}

int Count (int[]array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] array=Array(20);
PrintArray(array);
int result = Count(array);
System.Console.WriteLine(result);