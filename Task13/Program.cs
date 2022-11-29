// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num;

if (count < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (count > 1000)
    {
        count = count / 10;
    }
    Console.WriteLine(count % 10);

}
