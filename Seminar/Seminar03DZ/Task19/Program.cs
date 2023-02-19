// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
string Array = System.Console.ReadLine();
int Y=Array.Length;

if (Y == 5)
{
    if (Array[0] == Array[4] && Array[1] == Array[3])
    {
        System.Console.WriteLine("Число " + Array + " является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число " + Array + " не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Число " + Array + " не пятизначное"); 
}
    