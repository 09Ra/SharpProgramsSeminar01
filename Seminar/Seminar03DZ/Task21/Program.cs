// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координату X в точке А: ");
int[] coordsA = new int[3]; 
coordsA[0] = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координату Y в точке А: ");
coordsA[1] = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координату Z в точке А: ");
coordsA[2] = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координату X в точке B: ");
int[] coordsB = new int[3]; 
coordsB[0] = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координату Y в точке B: ");
coordsB[1] = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите координату Y в точке B: ");
coordsB[2] = Convert.ToInt32(System.Console.ReadLine());

double distans = Math.Round(Math.Sqrt( (int) Math.Pow((coordsB[0] - coordsA[0]), 2) + (int) Math.Pow((coordsB[1] - coordsA[1]), 2)+(int) Math.Pow((coordsB[2] - coordsA[2]), 2)),2); 

System.Console.WriteLine(distans);