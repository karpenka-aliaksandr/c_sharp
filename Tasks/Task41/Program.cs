// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateInputArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-ое(-е) число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int SumPositiveNumber(int[] arr)
{
    int sumPisitive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPisitive++;
    }
    return sumPisitive;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(i < length - 1 ? $"{arr[i]}, " : $"{arr[i]}");
    }
}

Console.Clear();
Console.WriteLine("Программа принимает с клавиатуры M чисел и считает, сколько чисел больше 0 ввёл пользователь.");

// Вариант ввода 1.
Console.WriteLine("Введите количество чисел М: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = CreateInputArray(m);

// Вариант ввода 2.
// Console.Write("Введите числа через \",\": ");
// string str = String.Empty + Console.ReadLine();
// int[] arrayNumbers = str.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

int sumPisitiveNumber = SumPositiveNumber(arrayNumbers);
Console.Write("Среди введеных чисел: ");
PrintArray(arrayNumbers);
Console.WriteLine($" количество положительных равно {sumPisitiveNumber}.");