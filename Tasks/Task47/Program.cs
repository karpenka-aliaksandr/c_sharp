// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int colums, double min, double max)
{
    double[,] matr = new double[rows, colums];
    Random rnd = new Random();
    double rndNumber = default;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            rndNumber=rnd.NextDouble() * (max - min) + min;  
            matr[i,j] = Math.Round(rndNumber,2);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++) 
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j],6} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


Console.WriteLine("Программа задает двумерный массив размером m х n, заполненный случайными вещественными числами.");
Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: min=");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: max=");
double max = Convert.ToDouble(Console.ReadLine());

double[,] matrix = CreateMatrixRndDouble(m, n, min, max);
PrintMatrix(matrix);