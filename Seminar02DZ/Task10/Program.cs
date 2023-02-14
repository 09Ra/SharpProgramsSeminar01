// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Ввведите трехзначное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

int result = number / 100;

if (result > 0 && result < 10)
{
    number = number % 100;
    number = number / 10;

    System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("Введенное число не трехзначное.");
}
