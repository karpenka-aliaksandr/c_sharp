// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber(int[] array, int num)
{
    for (int i = 0 ; i < array.Length; i++)
    if (array[i]==num) return true;
    
    return false; 
}

Console.WriteLine("Программа создает массив из 10 элементов, заполняет случайными числами из диапазона [-9;9] и ищет заданное пользователем число в массиве.");
Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = 10;
int min=-9;
int max=9;
int[] array = CreateArray(size, min, max);
PrintArray(array);
bool findNumber = FindNumber(array, number);
if (findNumber) 
{
    Console.WriteLine($"Да, число {number} в массиве есть.");
}
else Console.WriteLine($"Нет, числа {number} в массиве нет.");