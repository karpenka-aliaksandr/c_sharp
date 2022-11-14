// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool IsTreangle(int num1, int num2, int num3)
{
    bool first = num1 < num2 + num3;
    bool second = num2 < num1 + num3;
    bool therd = num3 < num2 + num1;
    return first && second && therd;
}


Console.WriteLine("Программа принимает на вход три числа и проверяет может ли существовать треугольник с сторонами такой длины");
Console.Write("Введите длину стороны a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны c: ");
int c = Convert.ToInt32(Console.ReadLine());
bool isTreangle = IsTreangle(a,b,c);
Console.WriteLine(isTreangle ? $"Да. Существует треугольник со сторонами {a},{b},{c}." 
                    : $"Нет. Не существует треугольник со сторонами {a},{b},{c}.");