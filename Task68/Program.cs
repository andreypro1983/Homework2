// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();

Console.WriteLine("Введите любое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число N:");
int n = Convert.ToInt32(Console.ReadLine());

int FindNOD(int maxValue, int minValue) 
{
     if(maxValue%minValue==0) return minValue;
     else return FindNOD(minValue,maxValue%minValue);   
  
}

Console.WriteLine((m >= n) ? $"Наибольшим общим делителем чисел {m} и {n} является {FindNOD(m, n)} " : $" Наибольшим общим делителем чисел {m} и {n} является {FindNOD(n, m)}");