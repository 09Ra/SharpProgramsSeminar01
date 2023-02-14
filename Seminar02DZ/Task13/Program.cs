// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Ввведите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

int count = 100;
int result = number / count;
int Integer = 0;
int Remainder = 0;
int index = 1;
int indresult = number / 10;

while (indresult > 9)      // находим количесво цифр в числе. Показывает на 1 меньше
{
    indresult = indresult / 10;
    index = index + 1;
}

if (result < 1)
{
    System.Console.WriteLine("Введенное число не имеет третьей цифры");
}
else if (result > 1 && result < 10)
{
    System.Console.WriteLine("Третья цифра введенного числа равна: " + number % 10);
}
else
{
    index = index - 2;  // Находим в какую степень надо возводить 10, чтобы получить трехзначное число при делении
    count = Convert.ToInt32(Math.Pow(10, index)); // возводим в степень, заодно конвертировав в целочисленный тип
    Integer = number / count;  // Находим 3-х значное число
    Remainder = Integer % 10; //Находим третью цифру в трехзначном числе
    System.Console.WriteLine("Третья цифра введенного числа равна: " + Remainder);
}
