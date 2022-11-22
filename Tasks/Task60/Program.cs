// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndUniqueInt(int rows, int colums, int depth, int min, int max)
{
    int[] uniqueNumbersArray = new int[max - min];
    int len = uniqueNumbersArray.Length;
    for (int i = 0; i < len; i++)                       //заполняем массив возможных случайных чисел
    {
        uniqueNumbersArray[i] = min + i;
    }
    int[,,] matr = new int[rows, colums, depth];
    Random rnd = new Random();
    int count = rnd.Next(0, len - 1);                   //индекс массива случайных чисел 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int shift = rnd.Next(1, len);           //случайное смещение
                count += shift;
                if (count >= len) count -= len;
                while (uniqueNumbersArray[count] == 0)  //эти числа уже использованы
                {
                    count++;
                    if (count >= len) count -= len;
                }
                matr[i, j, k] = uniqueNumbersArray[count];
                uniqueNumbersArray[count] = 0;
            }
        }
    }
    return matr;
}

void PrintCubeMatrix(int[,,] cubeMatr)
{
    for (int i = 0; i < cubeMatr.GetLength(0); i++)
    {
        for (int j = 0; j < cubeMatr.GetLength(1); j++)
        {
            for (int k = 0; k < cubeMatr.GetLength(2); k++)
            {
                Console.Write($"{cubeMatr[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}



Console.Clear();
int minRowsColumnsDepth = 3;
int maxRowsColumnsDepth = 5;
int minUniqueNumber = 10;
int maxUniqueNumber = 99;
Console.WriteLine($"Программа создает двумерных массива cо случайным (от {minRowsColumnsDepth} до {maxRowsColumnsDepth}) количеством строк, столбцов и глубиной");
Console.WriteLine($"и заполняет случайными неповторяющимися числами [{minUniqueNumber};{maxUniqueNumber}].");
Console.WriteLine("Далее программа построчно выводит массив, добавляя индексы каждого элемента.");

Random rnd = new Random();

int m = rnd.Next(minRowsColumnsDepth, maxRowsColumnsDepth + 1);
int n = rnd.Next(minRowsColumnsDepth, maxRowsColumnsDepth + 1);
int k = rnd.Next(minRowsColumnsDepth, maxRowsColumnsDepth + 1);
if (m * n * k > maxUniqueNumber - minUniqueNumber)
    Console.WriteLine($"Размер массива ({m},{n},{k}) превысил количество уникальных элементов");
else
{
    int[,,] cubeMatrix = CreateMatrixRndUniqueInt(m, n, k, minUniqueNumber, maxUniqueNumber);
    Console.WriteLine();
    Console.WriteLine($"Размер массива ({m},{n},{k})");
    Console.WriteLine();
    PrintCubeMatrix(cubeMatrix);
    Console.WriteLine();
}