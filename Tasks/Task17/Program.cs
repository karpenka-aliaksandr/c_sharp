// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Quorter(int x, int y)
{
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y>0) return 4;
    return 0;
}



Console.Write("Введите координату X:");
int x =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y:");
int y =Convert.ToInt32(Console.ReadLine());
int quorter = Quorter(x,y);
Console.WriteLine( quorter>0 ? 
                $"Указанные координаты сооответствуют четверти -> {quorter}" : 
                "Точка лежит на оси координат.");


