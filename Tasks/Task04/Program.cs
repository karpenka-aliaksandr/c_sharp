// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int n = 3;
Console.WriteLine($"Введите {n} числа: ");
int max = Convert.ToInt32(Console.ReadLine());
int nextNumber;
int count = 1;
while (count < n) 
{ 
    nextNumber = Convert.ToInt32(Console.ReadLine());
    if (nextNumber > max) max = nextNumber;
    count++;
}
Console.WriteLine($"max = {max}");