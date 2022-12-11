// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] CreateArrayRandomNumbers(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);

    }
    return array;
}
int GetSumEvenNumbers(int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] % 2 == 0) count += 1;

    }
    return count;
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArrayRandomNumbers(arrSize);
Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");
Console.WriteLine($"В массиве обнаружено {GetSumEvenNumbers(newArray)} четных чисел");

