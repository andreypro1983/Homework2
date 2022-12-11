// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] CreateArrayRandomNumbers(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble();
    }
    return array;
}

double GetDiffBetweenMaxAndMinArrayElements(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > max) max = arr[j];
        else if (arr[j] < min) min = arr[j];
    }
    return max - min;
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
double[] newArray = CreateArrayRandomNumbers(arrSize);
Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {GetDiffBetweenMaxAndMinArrayElements(newArray)}");