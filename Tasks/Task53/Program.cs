// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void ReplaceFirstLastRows(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int temp = matr[0, j];
        matr[0, j] = matr[matr.GetLength(0) - 1, j];
        matr[matr.GetLength(0) - 1, j] = temp;
    }
}



Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceFirstLastRows(matrix);
PrintMatrix(matrix);