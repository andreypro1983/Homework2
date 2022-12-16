// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.
// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента двумерного массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента двумерного массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine($"Полученные значения суммы стобцов: {String.Join(" | ",FindSumColumnsArray(array))}");
Console.WriteLine($"Полученное значение суммы элементов расположенных в четырех 'углах' двумерного массива: {FindSumCornerElementsArray(array)}"); 
Console.Write(IsExistElementArrayMoreThanValue(FindSumColumnsArray(array), FindSumCornerElementsArray(array)) ? "Столбец существует" : "Столбец не существует");

int[,] FillArray(int arrayRows, int arrayColumns, int MinValue, int MaxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(MinValue, MaxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("{0}\t", inputArray[i, j]);
        }
        Console.WriteLine();
    }
}


int FindSumCornerElementsArray(int[,] array)
{
    int sum = array[0, array.GetLength(1) - 1] + array[0, 0] + array[array.GetLength(0) - 1, 0] + array[array.GetLength(0) - 1, array.GetLength(1) - 1];

    return sum;
}

int[] FindSumColumnsArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j] += array[i, j];
        }
    }

    return newArray;
}

bool IsExistElementArrayMoreThanValue(int[] array, int value)
{
    bool isExist = false;
    int i = 0;
    while (isExist == false && i < array.Length)
    {
        if (array[i] > value) isExist = true;
        i++;
    }

    return isExist;
}

