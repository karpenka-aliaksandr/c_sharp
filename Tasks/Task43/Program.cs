// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPointCoordinates(double k1, double b1, double k2, double b2)
{
    double[] coordinates = new double[2];
    coordinates[0] = (b2-b1)/(k1-k2);
    coordinates[1] = k1 * coordinates[0] + b1;
    return coordinates;
}

void PrintCoordinatesArray(double[] coord)
{
    Console.WriteLine($"({coord[0]} ; {coord[1]})");
}

Console.WriteLine("Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения k1, b1, k2 и b2 задаются пользователем.");
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите смещение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите смещение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Прямые, заданные уравнениями y = {k1} * x + {b1}, y = {k2} * x + {b2}");
if (k1==k2) 
{
    Console.WriteLine(b1 == b2 ? " - коллинеарны" : " - параллельны");
}
else 
{
    double[] intersectionPointCoordinates = IntersectionPointCoordinates(k1,b1,k2,b2);
    Console.Write(" - пересекаются в точке с координатами ");
    PrintCoordinatesArray(intersectionPointCoordinates);
    Console.WriteLine();
}