// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента первой матрицы: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента первой матрицы: ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента второй матрицы: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента второй матрицы: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = FillArray(rows1, columns1, min1, max1);
int[,] array2 = FillArray(rows2, columns2, min2, max2);

PrintArray(array1);

PrintArray(array2);

if (columns1 != rows2) Console.WriteLine("Найти произведение указанных двух матриц не представляется возможным");
else
{
    Console.WriteLine("Результирующая матрица будет:");
    PrintArray(GetProductTwoMatrix(array1, array2));


}







int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
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
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetProductTwoMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }

    }


    return resultArray;
}