int numberA= new Random().Next(1, 10); // При этом numberA будет принимать значения от 1 до 9
Console.WriteLine(numberA); // Выводим на экран numberA, чтобы мы видели, какие рандомные числа выбрал компьютер
int numberB= new Random().Next(1, 10); 
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);