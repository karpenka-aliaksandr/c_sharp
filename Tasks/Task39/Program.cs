// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



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

void ReverseArray(int[] array)
{
    for (int i = 0; i < (array.Length / 2) ; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length-1-i];
            array[array.Length-1-i] = temp;
        }
}

int size = 4;
int min = 1;
int max = 9;
Console.WriteLine($"Программа создает массив из {size} элементов, заполняет случайными числами из диапазона [{min},{max}], и разворачивает массив.");
int[] array = CreateArrayInt(size, min, max);
PrintArray(array);
ReverseArray(array);
PrintArray(array);