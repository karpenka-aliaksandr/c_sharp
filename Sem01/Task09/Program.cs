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
