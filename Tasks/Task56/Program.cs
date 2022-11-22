// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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

int[] SumMatrixRows(int[,] matr)
{
    int[] sumMatrRows = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRows += matr[i,j];
        }
        sumMatrRows[i] = sumRows;
    }
    return sumMatrRows;
}


int MatrixMinSumRows(int[] sumMRows)
{
    int indexMinRows = 0;
    for (int i = 1; i < sumMRows.Length; i++)
    {
        if (sumMRows[i] < sumMRows[indexMinRows]) indexMinRows = i;
    }
    return indexMinRows+1;
}

Console.Clear();
Console.WriteLine("Программа создает двумерный массив cо случайным (от 3 до 5) количеством строк и столбцов и заполняет случайными числами [0;9].");
Console.WriteLine("Далее программа находит строку с наименьшей суммой элементов");
Random rnd = new Random();
int m = rnd.Next(3, 5 + 1);
int n = rnd.Next(3, 5 + 1);
int[,] matrix = CreateMatrixRndInt(m, n, 0, 9);

Console.WriteLine();
Console.WriteLine("Исходный массив.");
PrintMatrix(matrix);

int[] sumMatrixRows = SumMatrixRows(matrix);

int matrixMinSumRows = MatrixMinSumRows(sumMatrixRows);

Console.WriteLine();
Console.WriteLine($"С наименьшей суммой строка: {matrixMinSumRows}.");

