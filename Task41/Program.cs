// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArrayfromConsole(int arrSize)
{
    int[] array = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}

int CountQuantityPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > 0) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите количество чисел М: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray =FillArrayfromConsole(size);
Console.WriteLine($"Была введена следующая последовательность чисел: {String.Join(", ",newArray)}");
Console.WriteLine($"Было введено {CountQuantityPositiveNumbers(newArray)} числа больше ноля");

