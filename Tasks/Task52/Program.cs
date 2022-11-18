// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matr = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

double[] AverageOfColums(int[,] matrix)
{   
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);
    double[] averageOfColums = new double[colums];
    for (int j = 0; j < colums; j++)
    {   
        double sumColums = 0;
        for (int i = 0; i < rows; i++)
        {
            sumColums += matrix[i, j];
        }
        averageOfColums[j] = sumColums/rows;
    }   
    return averageOfColums;
}
void PrintResult(double[] matr)
{
    Console.Write("Средние арифметические элементов в каждом столбце равны: ");
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{Math.Round(matr[i],2)}");
        if (i<matr.Length-1) Console.Write("; ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Программа создает двумерный массив cо случайным (от 3 до 5) количеством строк и столбцов и заполняет случайными числами [0;9].");
Console.WriteLine("Далее программа находит среднее арифметическое каждого из столбцов.");
Random rnd = new Random();
int m = rnd.Next(3, 5 + 1);
int n = rnd.Next(3, 5 + 1);
int[,] matrix = CreateMatrixRndInt(m, n, 0, 9);
PrintMatrix(matrix);
double[] average = AverageOfColums(matrix);
PrintResult(average);