// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] MatrixProduct(int[,] matr1,int[,] matr2)
{ 
    int rows = matr1.GetLength(0);
    int columns = matr2.GetLength(1);
    int rowsColumns = matr1.GetLength(1);
    int[,] matrProduct = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int element = 0;
            for (int r = 0; r < rowsColumns; r++)
            {
                element += matr1[i,r]*matr2[r,j];
            }
            matrProduct[i,j] = element;
        }
    }
    return matrProduct;
}


Console.Clear();
int min = 0;
int max = 9;
int minRowsColumns = 2;
int maxRowsColumns = 4;

Console.WriteLine($"Программа создает два двумерных массива cо случайным (от {minRowsColumns} до {maxRowsColumns}) количеством строк и столбцов и заполняет случайными числами [{min};{max}].");
Console.WriteLine("Далее программа находит произведение этих матриц");
Random rnd = new Random();
int m = rnd.Next(minRowsColumns, maxRowsColumns + 1);
int n = rnd.Next(minRowsColumns, maxRowsColumns + 1);
int[,] matrix1 = CreateMatrixRndInt(m, n, min, max);
m = rnd.Next(minRowsColumns, maxRowsColumns + 1);
n = rnd.Next(minRowsColumns, maxRowsColumns + 1);
int[,] matrix2 = CreateMatrixRndInt(m, n, min, max);

Console.WriteLine();
Console.WriteLine("Исходная матрица 1.");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Исходная матрица 2.");
PrintMatrix(matrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Данные матрицы умножать нельзя");
}
else 
{
int[,] matrixProduct = MatrixProduct(matrix1,matrix2);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(matrixProduct);
}
