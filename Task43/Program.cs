// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double, double) FindCoordinatesCrossingLines (double firstLineK, double firstLineB, double secondLineK, double secondLineB)
{
    
    return (((secondLineB-firstLineB)/(firstLineK-secondLineK)),firstLineK*((secondLineB-firstLineB)/(firstLineK-secondLineK))+firstLineB);
} 


Console.Clear();
Console.Write("Введите число k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка пересечения заданных прямых равна ({FindCoordinatesCrossingLines(k1,b1,k2,b2).Item1},{FindCoordinatesCrossingLines(k1,b1,k2,b2).Item2})");



