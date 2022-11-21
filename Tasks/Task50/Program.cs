// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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
Console.WriteLine("Программа создает двумерный массив со случайным (от 1 до 5) количеством строк и столбцов и заполняет случайными числами (-99;99).");
Console.WriteLine("Далее программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента");
Console.WriteLine("или же указание, что такого элемента нет.");
Random rnd = new Random();
int m = rnd.Next(1, 5 + 1);
int n = rnd.Next(1, 5 + 1);
int[,] matrix = CreateMatrixRndInt(m, n, -99, 99);
PrintMatrix(matrix);

Console.Write("Введите номер строки массива: m=");
int mFind = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номар столбца массива: n=");
int nFind = Convert.ToInt32(Console.ReadLine());
bool isElementInMatrix = mFind>=1 && mFind <= matrix.GetLength(0) && nFind>=1 && nFind <= matrix.GetLength(1);
Console.WriteLine(isElementInMatrix ?
                    $"Значение элемента в строке {mFind} и столбце {nFind} равно {matrix[mFind - 1, nFind - 1]}" :
                    $"Такого элемента нет.");

