// Дополнительная задача (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами

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

(int, bool) FindEvenArrayLenght(int[] inputArray, bool isTrue)  //получение длины массива четных или нечетных чисел в нем
{
    int count = 0;

    for (int j = 0; j < inputArray.Length; j++)
    {
        if (isTrue == true && inputArray[j] % 2 == 0) count++;
        else if (isTrue == false && inputArray[j] % 2 != 0) count++;
    }
    return (count, isTrue);
}

int[] GetArrayEvenOrNotEvenNumbersFromArray(int[] arr, int len, bool isEven) //получение массива четных или нечетных чисел из исходного
{
    int[] resultArray = new int[len];

    //resultArray[0] = arr[0];
    int countNewArray = 0;

    for (int k = 0; k < arr.Length; k++)
    {
        if (isEven == true && arr[k] % 2 == 0)
        {
            resultArray[countNewArray] = arr[k];
            countNewArray++;
        }
        else if (isEven == false && arr[k] % 2 != 0)
        {
            resultArray[countNewArray] = arr[k];
            countNewArray++;
        }

    }
    return resultArray;
}

double FindAverageArray(int[] inputArray)  // нахождение среднего арифметического массива
{
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        sum += inputArray[i];
    }
    return Convert.ToDouble(sum) / Convert.ToDouble(inputArray.Length);
}
void PrintResultCompareEvenAndNotEvenAverages (double evenAverage,double notEvenAverage) // вывод результата сравнения средних арифметический значений элементов массивов с чётными и нечетными числами
{
   if(evenAverage==notEvenAverage)  Console.WriteLine("средн. арифм. значений элементов массива с чётными числами = средн. арифм. значений элементов с нечётными числами");
   else if(evenAverage>notEvenAverage) Console.WriteLine("средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами");
   else Console.WriteLine("средн. арифм. значений элементов массива с чётными числами < средн. арифм. значений элементов с нечётными числами");

}



Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива: ");
int arrMinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int arrMaxValue = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArrayRandomNumbers(arrMinValue, arrMaxValue, arrSize);
Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");

// Console.WriteLine ($"Длина четного массива{FindEvenArrayLenght(newArray, true).Item1}");
// Console.WriteLine ($"Длина нечетного массива{FindEvenArrayLenght(newArray, false).Item1}");
// Console.WriteLine($"Разница между средними арифметическими массивов четных и нечетных чисел равна {FindAverageArray(GetArrayEvenOrNotEvenNumbersFromArray(newArray, FindEvenArrayLenght(newArray, true).Item1, FindEvenArrayLenght(newArray, true).Item2)) - FindAverageArray(GetArrayEvenOrNotEvenNumbersFromArray(newArray, FindEvenArrayLenght(newArray, false).Item1, FindEvenArrayLenght(newArray, false).Item2))}");

PrintResultCompareEvenAndNotEvenAverages(FindAverageArray(GetArrayEvenOrNotEvenNumbersFromArray(newArray, FindEvenArrayLenght(newArray, true).Item1, FindEvenArrayLenght(newArray, true).Item2)),FindAverageArray(GetArrayEvenOrNotEvenNumbersFromArray(newArray, FindEvenArrayLenght(newArray, false).Item1, FindEvenArrayLenght(newArray, false).Item2)));
