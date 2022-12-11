Console.Write(" Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
//int r = Convert.ToInt32(Console.ReadLine()); 
int r = n;

Main(n);

bool IsPalindrome(int num)
{
    // n сохраняет заданное целое число
    int n = num;

    // rev хранит обратную сторону заданного целого числа
    int rev = 0;

    while (n > 1)
    {
        // это сохранит последнюю цифру n в переменной r
        // например, если n равно 1234, то r будет равно 4
        int r = n % 10;

        // добавляем r к rev вместо себя
        // например, если rev = 65 и r = 4, то новый rev будет 654
        rev = rev * 10 + r;

        // удалить последнюю цифру из n
        // например, если n равно 1234, то новое n будет 123
        n = n / 10;
    }

    // это выражение вернет 1, если заданное число равно
    // наоборот; в противном случае он вернет 0
    return (num == rev);
}

int Main(int n)
{
    //n = 12321;

    if (IsPalindrome(n))
    {
        Console.WriteLine("Palindrome");
    }
    else
    {
        Console.WriteLine("Not Palindrome");
    }

    return 0;
}