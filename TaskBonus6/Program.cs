// Дополнительная задача (задача со звёздочкой): Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

Console.WriteLine("Введите любое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число N:");
int n = Convert.ToInt32(Console.ReadLine());

int Accerman(int value1, int value2)
{
    if (value1 == 0) return value2 + 1;
    else if (value2 == 0) return Accerman(value1 - 1, 1);
    else return Accerman(value1 - 1, Accerman(value1, value2 - 1));
}

Console.WriteLine($"A({m},{n}) = {Accerman(m, n)}");