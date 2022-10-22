// Задача 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру числа.
// 
// 78 -> 8
// 12 -> 2
// 85 -> 8

int MaxDigit(int number)
{
    int firstDigit = number / 10; // 78 / 10 = 7
    int secondDigit = number % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {num}");

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа {num} = {maxDigit}");
