// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int Sum(int x, int y)
{
    int result = 1;

    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}

void Print(int a, int b, int exponentiation)
{
   System.Console.WriteLine($"{a} в степени {b} равен {exponentiation}"); 
}


int a = Input("Введите А: ");
int b = Input("Введите B: ");

int exponentiation = Sum(a, b);
Print(a,b,exponentiation);