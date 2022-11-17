// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] CreateMatrixSumIndex(int rows, int colums)
{
    int[,] matr = new int[rows, colums];
        for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matr[i,j] = i+j;
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
            Console.Write($"{matr[i,j],5} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixSumIndex(m, n);
PrintMatrix(matrix);