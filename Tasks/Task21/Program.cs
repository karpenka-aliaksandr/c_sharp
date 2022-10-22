// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2));
}

Console.Write("Введите координату x точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double distance3D = Math.Round(Distance3D(xa,ya,za,xb,yb,zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками A({xa},{ya},{za}) и B({xb},{yb},{zb}) равно {distance3D}");