// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] Array(int size, int leftRange, int rightRange)
{
    int[] array= new int[size];
    Random rand=new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rand.Next(leftRange,rightRange+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+string.Join(", ",array)+"]");
}

int Sum (int[]array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1)
        {
            result=result+array[i];
        }
    }
    return result;
}

int[] array=Array(7,-10,10);
PrintArray(array);
int result = Sum(array);
System.Console.WriteLine(result);