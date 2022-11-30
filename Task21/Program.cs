// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите X точки А:");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y точки А:");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z точки А:");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X точки B:");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y точки B:");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z точки B:");
int zb = Convert.ToInt32(Console.ReadLine());

// √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double result = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine (Math.Round(result,2,MidpointRounding.ToZero));