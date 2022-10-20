// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Table(int n)
{
    if (n > 0)
    {
        int index = 1;
        while (index <= n)
        {
            Console.WriteLine($"{index,4} {index*index,5}");
            index++;
        }

    } 
    else Console.WriteLine("Некорректное число");
}


Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);
