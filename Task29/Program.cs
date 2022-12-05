// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int count)
{
    Random rnd = new Random();
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(size > 0 ? $"Задан массив [{String.Join(",", FillArray(size))}]" : $"Введенная размерность массива {size} не допустима");




// Вариант 2 с попыткой переопределить размерность массива, если пользователь при вводе чисел ввел пустую строку.
// Закончилось ничем, так как планировал использовать кортеж для получения заполненного массива, и переменной, равной количеству итераций корректного присвоения значения массиву в методе, но оказалось, что в моей реализации, при попытке получить 2 значение после 1 приходится снова вводить значения массива. Такой вариант не вариант.
// (int[],int) FillArray(int count)
// {
//     //Random rnd = new Random();
//     int[] arr = new int[count];
//     int counter=0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"Введите {i} элемент массива: ");
//         string temp = Console.ReadLine();

//         if (temp != String.Empty) 
//         { arr[i] = Convert.ToInt32(temp);
//         count++;
//         }
//         else 
//         {
//         arr[i]=    
//         return (arr,counter);
//         }
//     }
//     return (arr, counter);
// }

// string PrintArray(int[] arr)
// {
//     string print = "[";
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         print = print + arr[i] + ", ";

//     }
//     print = print + arr[arr.Length - 1] + "]";
//     return print;
// }

// int [] GetArrayToNewLength (int [] old_arr, int newCount)
// {
//    int [] newArray =new int[newCount];
//    for (int i=0;i<newCount;i++)
//    {
//  newArray[i]=old_arr[i];
//     }  
// return newArray;
// }

// Console.Clear();
// Console.WriteLine("Введите размерность массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(size).Item1;
// int newCount = FillArray(size).Item2;
// Console.WriteLine(array.Length>newCount ? $"{PrintArray(GetArrayToNewLength(array,newCount))}" : "{PrintArray(array)}");

