// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] CreateArrayFib(int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < number; i++)
    {
        if (i < 2) arr[i] = i;
        else arr[i] = arr[i - 1] + arr[i - 2];
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


Console.WriteLine("Программа выводит первые N чисел Фибоначчи.");
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] fib = CreateArrayFib(n);
Console.Write($"Первые {n} чисел Фибоначчи: ");
PrintArray(fib);

