// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

ulong FunctionAkkerman(ulong m, ulong n)
{
    if (m == 0) 
    {
        return n+1;
    }
    else return n == 0 ? FunctionAkkerman(m-1,1) : FunctionAkkerman(m-1,FunctionAkkerman(m,n - 1));
}


Console.Clear();
Console.WriteLine("Программа вычисляет функцию Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
ulong functionAkkerman = FunctionAkkerman((ulong)m,(ulong)n);
Console.WriteLine($"Функция Аккермана для коэффициентов m={m} и n={n} равна: {functionAkkerman}");