// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

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

int[] MoveArrayPosition(int[] array, bool isLeft)
{
    int[] newArray = new int[array.Length];
    //int 

    if (isLeft == true)

    {
        int firstValue = array[0];
        for (int j = 0; j < array.Length - 1; j++)
        {
            newArray[j] = array[j + 1];
        }
        newArray[newArray.Length - 1] = firstValue;
    }
    else
    {
        int lastValue = array[array.Length - 1];
        for (int j = 0; j < array.Length - 1; j++)
        {
            newArray[j + 1] = array[j];
        }
        newArray[0] = lastValue;

    }

    return newArray;
}

bool ConvertInputInfoAboutMoveArrayToBool(string input)
{

    if (input.ToLower() == "да") return true;
    return false;

    //     Console.WriteLine("Введенная информация по сдвигу массива не корректна. Завершение работы задачи");

}


Console.Clear();
Console.Write("Введите размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int arrMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int arrMaxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Сдвигаем массив на 1 влево(отвечаем 'Да') или на 1 вправо (отвечаем 'Нет'): ");
string? moveLeft = Console.ReadLine();  // знак ? после string позволяет хранить переменной значение null
if (String.IsNullOrEmpty(moveLeft)|| (moveLeft.ToLower() != "да"&& moveLeft.ToLower() != "нет"))
{
    Console.WriteLine("Не корректно введен ответ на последний запрос. Работа задачи будет завершена");
    goto Finish;
}
//Console.WriteLine(moveLeft);
int[] inputArray = CreateArrayRandomNumbers(arrMinValue, arrMaxValue, arrSize);
Console.Write($"[{String.Join(", ", inputArray)}]");
Console.Write($" - [{String.Join(", ", MoveArrayPosition(inputArray, ConvertInputInfoAboutMoveArrayToBool(moveLeft)))}]");
Finish:
Console.WriteLine("");

