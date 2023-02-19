// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число N: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs - берет модуль, т.е абсолютную величину

for (int i = 1;i<= number; i++)
{
    System.Console.Write(Math.Pow(i, 3)+" ");
}
