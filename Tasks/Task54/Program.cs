// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixSortDescendingInRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = matr.GetLength(1) - 1; k > 0 ; k--)
        {
            for (int j = 0; j < k; j++)   
            {
                if (matr[i,j] < matr[i,j+1]) (matr[i,j], matr[i,j+1]) = (matr[i,j+1], matr[i,j]);
            }
        }
    }

}

Console.Clear();
Console.WriteLine("Программа создает двумерный массив cо случайным (от 3 до 5) количеством строк и столбцов и заполняет случайными числами [0;9].");
Console.WriteLine("Далее программа упорядочит по убыванию элементы каждой строки двумерного массива.");
Random rnd = new Random();
int m = rnd.Next(3, 5 + 1);
int n = rnd.Next(3, 5 + 1);
int[,] matrix = CreateMatrixRndInt(m, n, 0, 9);

Console.WriteLine();
Console.WriteLine("Исходный массив.");
PrintMatrix(matrix);

MatrixSortDescendingInRows(matrix);

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой строки:");
PrintMatrix(matrix);
