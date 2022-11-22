// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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

int[] MinElementIndexRowColumn(int[,] matr)
{
    int min = matr[0,0];
    int[] indexes = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]< min)
            {   
                min = matr[i,j];
                indexes[0] = i;
                indexes[1] = j;
            } 
        }
    }
    return indexes;
}

int[,] CreateNewMatrix(int[,] matr, int[] ind)
{
    int[,] newMatr = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    int row = 0;
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        if (row == ind[0]) row++; 
        int column = 0;
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            if (column == ind[1]) column++; 
            newMatr[i, j] = matr[row,column];
            column++;
        }
        row++;
    }
    return newMatr;
}






Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, -99, 99);
PrintMatrix(matrix);
int[] indexesMinElement = MinElementIndexRowColumn(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент в строке с индексом {indexesMinElement[0]}, столбце с индексом {indexesMinElement[1]}");
Console.WriteLine();

int[,] newMatrix = CreateNewMatrix(matrix, indexesMinElement);

PrintMatrix(newMatrix);


