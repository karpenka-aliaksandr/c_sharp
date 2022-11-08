// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponentiation(int a, int b)
{   
    double exp = 1;
    for (int i = 1; i <= b; i++)    
    {
        exp *= a;
    }
    for (int j = b; j < 0; j++)    
    {
        exp = exp * (1/(double)a);
    }
    return exp;
}


Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в целую степень B.");
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==0 && b<0) 
    Console.Write($"Неправильный ввод.");
else
{
    double exponentiation = Exponentiation(a,b);
    Console.Write($"Число {a} в степени {b} равно {exponentiation}");
}