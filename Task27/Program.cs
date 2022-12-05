// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FindSumDigitsInNumber(int num)
{
    int result = 0;
    int count = Math.Abs(num);
    while (count >= 1)
    {
        result = result + count % 10;
        count = count / 10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number != 0 ? $"Сумма цифр в числе {number} равна {FindSumDigitsInNumber(number)} " : "Вводить число 0 недопустимо");
