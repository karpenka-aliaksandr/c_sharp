// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


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

//int sumMinus ()
int[] GetSumPositiveNegativeElements (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i]>0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    return new int[]{sumPositive,sumNegative};
}

Console.WriteLine("Программа создает массив из 12 элементов, заполняет случайными числами из диапазона [-9;9]");

int size = 12;
int min=-9;
int max=9;
int[] array = CreateArray(size, min, max);
PrintArray(array);
int[] sumPositiveNegativeElements = GetSumPositiveNegativeElements(array);
Console.WriteLine($"Сумма положительных элементов: {sumPositiveNegativeElements[0]}, сумма отрицательных элементов {sumPositiveNegativeElements[1]}");
