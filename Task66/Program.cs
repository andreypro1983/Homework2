// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

Console.WriteLine("Введите любое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int value1, int value2) 
{
    if (value1 == value2) return value1;
    return value1 + SumNumber(value1 + 1, value2);      
}

Console.WriteLine((m < n) ? $"Сумма натуральных чисел от {m} до {n} равна {SumNumber(m, n)} " : $" Значение M = {m} должно быть меньше значения N = {n}");

