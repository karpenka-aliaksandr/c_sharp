// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"



void NaturalNumbersMN(int numM, int numN)
{
    if (numM == numN)
    {
        Console.Write($"{numM} ");
        return;
    }
    Console.Write($"{numM} ");
    NaturalNumbersMN(numM > numN ? numM - 1 : numM + 1, numN);
}


Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumbersMN(m, n);