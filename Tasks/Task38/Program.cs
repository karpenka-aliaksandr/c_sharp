// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max, int round)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, round);
    }
    return array;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

double MaxElementOfArray(double[] array)
{
    double max = array[0];
    for (int i=1; i<array.Length; i++)
        if (array[i]>max) max=array[i];
    return max;
}
double MinElementOfArray(double[] array)
{
    double min = array[0];
    for (int i=1; i<array.Length; i++)
        if (array[i]<min) min=array[i];
    return min;
}
double GetDifferenceMaxMin(double[] array, int round)
{
    double differenceMaxMin = MaxElementOfArray(array)-MinElementOfArray(array);
    return Math.Round(differenceMaxMin, round);
}

int size = 10;
int min = -9;
int max = 9;
int round = 1;
Console.WriteLine($"Программа создает массив из {size} элементов вещественных чисел в диапазоне [{min},{max}]. Находит разницу между максимальным и минимальным элементами массива.");
double[] array = CreateArrayRndDouble(size, min, max, round);
PrintArray(array);
double differenceMaxMin = GetDifferenceMaxMin(array,round);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {differenceMaxMin}");
