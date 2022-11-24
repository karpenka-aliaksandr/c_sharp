﻿// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12


int SumDigit(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigit(num/10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} равна: {sumDigit}.");

