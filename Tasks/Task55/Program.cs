// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


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

void ReplaceRowsColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0)-1; i++) 
    {   
        for (int j = i+1; j < matr.GetLength(1); j++)
        {
            // int temp = matr[i,j];
            // matr[i,j] = matr[j,i];
            // matr[j,i] = temp;
            (matr[i,j], matr[j,i]) = (matr[j,i], matr[i,j]);            
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
if (m==n) 
{
ReplaceRowsColumns(matrix);
PrintMatrix(matrix);
}
else Console.WriteLine("Массив не квадратный, замена невозможна.");