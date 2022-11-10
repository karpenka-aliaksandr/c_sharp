// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].


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

int FindNumbers(int[] array, int minNum, int maxNum)
{
    int count = 0;
    for (int i = 0 ; i < array.Length; i++)
    if (array[i]>=minNum && array[i] <= maxNum) count++;
    
    return count; 
}

Console.WriteLine("Программа задаёт одномерный массив из 123 случайных чисел. Находит количество элементов массива, значения которых лежат в отрезке [10,99]");
int size = 123;
int min=0;
int max=1000;
int[] array = CreateArray(size, min, max);
PrintArray(array);
int minFindNumber = 10;
int maxFindNumber = 99;
int findNumbers = FindNumbers(array, minFindNumber, maxFindNumber);

Console.WriteLine($"В массиве {findNumbers} чисел из диапазона [{minFindNumber},{maxFindNumber}].");