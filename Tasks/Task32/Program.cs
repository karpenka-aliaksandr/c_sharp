// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i<size; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i<arr.Length-1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

void ChangePositiveNegative(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    array[i]=-array[i];
}

Console.WriteLine("Программа создает массив из 12 элементов, заполняет случайными числами из диапазона [-9;9]");

int size = 10;
int min=-9;
int max=9;
int[] array = CreateArray(size, min, max);
PrintArray(array);
ChangePositiveNegative(array);
PrintArray(array);
