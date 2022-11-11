// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int EvenNumbers(int[] array)
{
    int evenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) evenNumbers++;
    return evenNumbers;
}

int size = 10;
int min = 100;
int max = 999;
Console.WriteLine($"Программа создает массив из {size} элементов, заполняет случайными положительными трехзначными числами и показывает количество четных чисел в массиве.");
int[] array = CreateArrayInt(size, min, max);
PrintArray(array);
int evenNumbers = EvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве: {evenNumbers}");