// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int x, int y)
{

    if (x == y) return x;
    return y + Sum(x, y - 1);

}

void Print(int sum, int x, int y)
{
    System.Console.WriteLine($"Сумма натуральных элементов в промежутке {x} и {y} равна {Sum(x, y)}");
}

int m = Input("Введите М: ");
int n = Input("Введите N: ");
int sum = Sum(m, n);
Print(sum, m, n);

