// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ",FindAvarageColumnsArray(array))}.");


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


decimal[] FindAvarageColumnsArray(int[,] array)
{
    decimal[] newArray = new decimal[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           newArray[j]+=array[i,j];
        }
    }
   for (int k=0;k<newArray.Length;k++)
   {
    newArray[k]=Math.Round(newArray[k]/array.GetLength(0),2);
   }

   return newArray;
}