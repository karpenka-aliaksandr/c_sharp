(int, int) Rotate((int, int) deltas)
{
    (int, int) deltasRotate = (0, 0);
    switch (deltas)
    {
        case (0, 1): deltasRotate.Item1 = 1; deltasRotate.Item2 = 0; break;
        case (1, 0): deltasRotate.Item1 = 0; deltasRotate.Item2 = -1; break;
        case (0, -1): deltasRotate.Item1 = -1; deltasRotate.Item2 = 0; break;
        case (-1, 0): deltasRotate.Item1 = 0; deltasRotate.Item2 = 1; break;
    }
    return deltasRotate;
}

int[,] CreateMatrixIntSpiral(int rows, int columns)
{
    int[,] matrSpiral = new int[rows, columns];
    int number = 1;
    int row = 0;
    int column = 0;
    int deltaRow = 0;
    int deltaColumn = 1;
    while (matrSpiral[row, column] == 0)
    {
        matrSpiral[row, column] = number++;
        if (!(row + deltaRow >= 0 && row + deltaRow < rows && column + deltaColumn >= 0 && column + deltaColumn < columns))
        {   
            (deltaRow, deltaColumn) = Rotate((deltaRow, deltaColumn));
        }
        else
        {   
            if (matrSpiral[row+deltaRow, column+deltaColumn] !=0)
            (deltaRow, deltaColumn) = Rotate((deltaRow, deltaColumn));
        }
        if (row + deltaRow >= 0 && row + deltaRow < rows && column + deltaColumn >= 0 && column + deltaColumn < columns)
        {
            row += deltaRow;
            column += deltaColumn;
        }
    }
    return matrSpiral;
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


Console.Clear();
int minRowsColumns = 1;
int maxRowsColumns = 5;

Console.WriteLine($"Программа создает двухмерный массив cо случайным (от {minRowsColumns} до {maxRowsColumns}) количеством строк и столбцов и заполняет числами по порядку по спирали.");
Random rnd = new Random();
int m = rnd.Next(minRowsColumns, maxRowsColumns + 1);
int n = rnd.Next(minRowsColumns, maxRowsColumns + 1);
Console.WriteLine($"Размер массива [{m},{n}]");
Console.WriteLine();
int[,] matrixSpiral = CreateMatrixIntSpiral(m, n);

PrintMatrix(matrixSpiral);
