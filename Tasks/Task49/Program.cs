// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matr = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matr[i,j] = rnd.Next(min,max+1);
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
            Console.Write($"{matr[i,j],4} ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void ReplaceEvenIndexElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2) 
    {   
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i,j]*=matr[i,j];
        }
    }
}



Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceEvenIndexElements(matrix);
PrintMatrix(matrix);