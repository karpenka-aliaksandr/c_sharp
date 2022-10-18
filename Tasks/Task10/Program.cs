// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int number)
{
    int secondDigit = -1; // возвращается если число не трехзначное
    if (number >= 100 && number <= 999) 
    {
        secondDigit = number / 10 % 10;
    }
    return secondDigit;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(Math.Abs(number));
Console.WriteLine(secondDigit >= 0 ? 
$"Вторая цифра числа {number} = {secondDigit}": 
$"Число {number} - не трехзначное.");