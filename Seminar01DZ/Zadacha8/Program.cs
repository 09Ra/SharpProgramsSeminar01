// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number >= 2)
{
    for (int i = 2; i <= number; i = i + 2)
    {
        System.Console.Write(i + " ");
    }
}
else if (number == 1)
{
    System.Console.Write("В данном промежутке нет четных чисел");
}
else if (number == 0)
{
    System.Console.Write("0-четное число, но не попадает в наш список");
}
else
{
    System.Console.WriteLine("Данное число отрицательное и не попадает в наш список");
}