// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Fact(int num)
{
    int fact = num--; //fact = num; num = num - 1;
    while (num>1) 
    {
        fact *= num--; // fact = fact * num; num = num - 1;
    }
    return fact;
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int fact = Fact(number);
Console.WriteLine($"Факториал числа {number} равен {fact}.");