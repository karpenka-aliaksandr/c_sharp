// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNaturalNumber(int num, int numStart)
{
    if (num > 1)
    {
        if (num == numStart)
        {
            Console.Write($"N = {num} -> \"");
        }
    Console.Write($"{num}, ");
    PrintNaturalNumber(num-1, numStart);
    }
    else
    {
        Console.WriteLine("1\"");
        return; 
    }
}

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0) 
{   
    PrintNaturalNumber(n,n);
}
else Console.WriteLine("Введено ненатуральное число.");