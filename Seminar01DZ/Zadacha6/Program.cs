// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number >= 0) // >= 0, т.к 0 считается четным числом
{
    if (number % 2 == 0)
    {
        System.Console.WriteLine("Введенное число является четным числом");
    }
    else
    {
        System.Console.WriteLine("Введенное число является нечетным числом");
    }
}
else
{
    System.Console.WriteLine("Введенное число является нечетным числом");
}