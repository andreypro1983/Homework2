// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number.ToString().Length != 3) Console.WriteLine("Введено не трехзначное число");
else
{
    int digit2 = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} - {digit2}");
}
