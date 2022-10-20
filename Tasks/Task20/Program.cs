// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance (int a1, int a2, int b1, int b2)
{
    double distance = Math.Sqrt(Math.Pow(b1-a1,2)+Math.Pow(b2-a2,2));
    return Math.Round(distance,2,MidpointRounding.ToZero);
    
}


Console.Write("Введите первую координату точки A:");
int a1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки A:");
int a2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки B:");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки B:");
int b2=Convert.ToInt32(Console.ReadLine());

double distance = Distance(a1, a2, b1, b2);
Console.WriteLine($"Расстояние между точками A({a1},{a2}) и B({b1},{b2}) равно {distance}");
