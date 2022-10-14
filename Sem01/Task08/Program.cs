// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= n)
{
    Console.Write(count);
    count=count+2;
    if (count <= n) Console.Write(", ");
}