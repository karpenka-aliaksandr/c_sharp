// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumber(int numM, int numN)
{
    if (numM == numN) return numN;
    return numM < numN ? numM + SumNaturalNumber(numM + 1, numN) : numN + SumNaturalNumber(numM, numN + 1);
}



Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && m > 0)
{
    int sum = SumNaturalNumber(m, n);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна: {sum}.");
}
else
{
    Console.WriteLine("Введено ненатуральное число.");
}