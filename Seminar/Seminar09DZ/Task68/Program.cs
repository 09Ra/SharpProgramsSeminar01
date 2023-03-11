/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */

int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    if (x > 0 && y == 0) return Akkerman(x - 1, 1);
    if (x > 0 && y > 0) return Akkerman(x - 1, Akkerman(x, y - 1));
    return Akkerman(x, y);
}

void Print(int sum, int x, int y)
{
    System.Console.WriteLine($"A({x},{y}) равна {Akkerman(x, y)}");
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");
int result = Akkerman(m, n);
Print(result, m, n);


