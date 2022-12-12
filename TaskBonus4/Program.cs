// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.
// [1,2,3,3] -> [1,2,3,4]
int[] CreateArrayRandomNumbers(int MinValue, int MaxValue, int size)  //заполнение массива случайными числами
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(MinValue, MaxValue + 1);

    }
    return array;
}

int GetUniqueValueNotInArray (int[] arr)
{ 
    int max=0;
    for (int i=0;i<arr.Length;i++)
    {
       if (arr[i]>max) max=arr[i];

    }
    return max+1;
}

int[] FindAndReplaceRepeatNumbers (int[] arr)
{
  int [] newArray=(int [])arr.Clone();
  for (int j=0;j<newArray.Length-1;j++)
  {
if (newArray[j+1]==newArray[j]) newArray[j+1]=GetUniqueValueNotInArray(newArray);
  }
return newArray;
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int arrMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int arrMaxValue = Convert.ToInt32(Console.ReadLine());
int[] inputArray = CreateArrayRandomNumbers(arrMinValue, arrMaxValue, arrSize);
Console.Write($"[{String.Join(", ", inputArray)}] -> ");
Console.Write($"[{String.Join(", ", FindAndReplaceRepeatNumbers(inputArray))}]");