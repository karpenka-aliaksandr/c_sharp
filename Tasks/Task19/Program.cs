// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsFiveDigit(int number)
{
    int numberAbs = Math.Abs(number);
    return (numberAbs >= 10000 && numberAbs <= 99999);
}

bool IsPalindrome(int number)
{
    int numberAbs = Math.Abs(number);
    int numberReverse = 0;
    int numberTemp = numberAbs;
    while (numberTemp > 0) 
    {
        numberReverse = numberReverse * 10 + numberTemp % 10;
        numberTemp /= 10;
    }
    return numberAbs == numberReverse;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsFiveDigit(number))
{
    Console.Write($"Число {number} - ");
    Console.WriteLine(IsPalindrome(number) ? "является палиндромом." : "не является палиндромом.");
}
else
{
    Console.WriteLine($"Число {number} - не пятизначное.");
}