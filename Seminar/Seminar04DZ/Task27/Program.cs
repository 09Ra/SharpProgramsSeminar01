// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int number)
{
    int sum = 0;
    while (number > 10)
    {
        sum += number % 10;
        number = number / 10;
    }
    sum += number;
    return sum;
}

void Print (int sum, int number)
{
   System.Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
}
int number = Input("Введите число: ");
int sum = Sum(number);
Print(sum, number);




