// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
int count=n;
if (count>m) Console.Write("Введенное число N больше числа M");
else 
{
while (count<m)
{
  Console.Write ($"{Math.Pow(count,3)}, ");
  count++;  
}
Console.Write ($"{Math.Pow(count,3)}");
}