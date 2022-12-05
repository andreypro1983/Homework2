// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsCorrectNumbers(a, b) ? $"Результат возведения числа {a} в степень {b} = {FindPowerNumbers(a, b)}" : "Введенные числа не допустимы");


int FindPowerNumbers(int number, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result = result * number;
    }
    return result;
}

bool IsCorrectNumbers(int number, int pow)
{
    if (number > 0 && pow >= 1) return true;
    else return false;
}