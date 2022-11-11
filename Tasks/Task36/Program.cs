// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SumEvenPositionNumbers(int[] array)
{
    int sumEvenPositionNumbers = 0;
    for (int i = 1; i < array.Length; i+=2)
        sumEvenPositionNumbers += array[i];
    return sumEvenPositionNumbers;
}

int size = 10;
int min = -9;
int max = 9;
Console.WriteLine($"Программа создает массив из {size} элементов, заполняет случайными числами из диапазона [{min},{max}] и высчитывает сумму элементов, стоящих на четных позициях");
int[] array = CreateArrayInt(size, min, max);
PrintArray(array);
int sumEvenPositionNumbers = SumEvenPositionNumbers(array);
Console.WriteLine($"Cумма элементов, стоящих на четных позициях: {sumEvenPositionNumbers}");