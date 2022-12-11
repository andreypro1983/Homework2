// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] CreateArrayRandomNumbers(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-1000, 1001);

    }
    return array;
}

int GetSumNumbersNotEvenPosition(int[] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (j % 2 != 0) sum += arr[j];

    }
    return sum;
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArrayRandomNumbers(arrSize);
Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях равна {GetSumNumbersNotEvenPosition(newArray)}");