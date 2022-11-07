//24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36


int SumNumbers(int a)
{
    int sum=a--;
    while (a>0)
    {
        sum+=a--;
    }
    return sum;
}


Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(a);
Console.WriteLine($"Сумма чисел от 1 до {a} равен {sumNumbers}");