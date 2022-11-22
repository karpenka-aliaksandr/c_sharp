// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] MatrixToArray(int[,] matr)
{

    int[] arr = new int[matr.Length];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[i * matr.GetLength(1) + j] = matr[i, j];
        }
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[,] FrequencyMatrix(int[] arr)
{
    int countElements = 1;
    int element = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != element)
        {
            countElements++;
            element = arr[i];
        }
    }
    int[,] frequency = new int[countElements, 2];
    int count = 0;
    for (int j = 0; j < countElements; j++)
    {
        int elem = arr[count];
        int sumElem = 1;
        count++;
        if (count < arr.Length)
        {
            while (arr[count] == elem)
            {
                sumElem++;
                count++;
                if (count == arr.Length) break;
            }
        }
        frequency[j, 0] = elem;
        frequency[j, 1] = sumElem;
    }
    return frequency;
}


Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, 0, 9);
PrintMatrix(matrix);

Console.WriteLine();

int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
int[,] frequencyMatrix = FrequencyMatrix(array);
PrintMatrix(frequencyMatrix);