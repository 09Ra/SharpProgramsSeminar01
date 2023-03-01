// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] Array(int size, int leftRange, int rightRange)
{
    double[] array= new double[size];
    Random rand=new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rand.Next(leftRange,rightRange+1)+Math.Round(rand.NextDouble(),2);
    }
    return array;
}


void PrintArray(double[] array)
{
    System.Console.WriteLine("["+string.Join(", ",array)+"]");
}

double Max (double[]array)
{
    double max=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max=array[i];
        }
    }
    return max;
}

double Min (double[]array)
{
    double min=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
        {
            min=array[i];
        }
    }
    return min;
}

double[] array=Array(7,-10,10);
PrintArray(array);
double max=Max(array);
System.Console.WriteLine($"Максимальный элемент вещественного массива равен: {max}");
double min=Min(array);
System.Console.WriteLine($"Минимальный элемент вещественного массива равен: {min}");
double result = max-min;
System.Console.WriteLine(result);
