// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] CreateArray(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i<len; i++)
    {
        arr[i] = rnd.Next(1,100);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i<arr.Length-1) Console.Write(",");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Программа, которая задаёт массив из 8 элементов (случайные числа от 1 до 99) и выводит их на экран.");
int length = 8;
int[] array = CreateArray(length);
PrintArray(array);
