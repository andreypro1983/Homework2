// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8
Console.Clear();

Console.Write("Введите любое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число N: ");
int n = Convert.ToInt32(Console.ReadLine());


void FindNumber(int value1, int value2) 

{
    if (value1 % 2 == 0)
    {
        if (value1 == value2 || value1 == value2 - 1) Console.Write(value1);
        else Console.Write(value1 + " , ");
    }
    if (value1 != value2) FindNumber(value1 + 1, value2);
    else return;

}

if (m > n) FindNumber(n, m);
else FindNumber(m, n);


