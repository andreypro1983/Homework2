// Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8

Console.Clear();
Console.Write("Введите радиус круга: ");
double size = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(size != 0 ? $"В значении площади круга {FindAreaofCircle(size)} максимальной цифрой является {FindMaxNumber(FindAreaofCircle(size))}" : $"Значение радиуса круга не может быть равно нолю");



int FindMaxNumber(int value)
{
    int number = value;
    int max = 0;
    while (number >= 1)
    {
        if (max < number % 10) max = number % 10;
        number = number / 10;
    }
    return max;
}

int FindAreaofCircle(double radius)
{
    double area = Math.Pow(radius, 2) * Math.PI;
    return Convert.ToInt32(Math.Round(area, 0));
}
