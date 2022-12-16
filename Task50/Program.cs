// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет
//using System.Linq;

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

Console.Write("Введите индексы элемента массива для вывода его значения в формате ИНДЕКС СТРОКИ,ИНДЕКС СТОЛБЦА: ");
string? findValue = Console.ReadLine();

if (String.IsNullOrEmpty(findValue)) Console.WriteLine("Введено некорректное значение");
else
{
    int firstValue = int.Parse(findValue.Substring(0, findValue.IndexOf(",")));
    int secondValue = int.Parse(findValue.Substring(findValue.IndexOf(",") + 1));

  //  var findElement = findValue.Select(item =>item.Split(",")) ; //1,3          1 3
  //                       .Select(e => (int.Parse(e[0]), int.Parse(e[1]))).ToArray();

    Console.WriteLine(firstValue <= rows && secondValue <= columns ? $"Значение искомого элемента равно {array[firstValue, secondValue]}" : "Элемента с данными индексами в массиве нет");
}





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

// int GetValueInputElementArray (int [,] inputArray,int rowValue, int columnsValue)
// {
//     return inputArray[rowValue,columnsValue];
// }