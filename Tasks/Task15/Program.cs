// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.третья цифра

// 6 -> да
// 7 -> да
// 1 -> нет

bool IsDateOfWeek (int number)
{
    return (number >= 1 && number <= 7);
}

bool IsHoliday (int number)
{
    return (number == 6 || number == 7); 
}

Console.WriteLine("Введите число дня недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (IsDateOfWeek(dayOfWeek))
{
    Console.WriteLine(IsHoliday(dayOfWeek) ? "Да, это выходной." : "Нет, это будний день.");
}
else
{
    Console.WriteLine($"{dayOfWeek} - не число дня недели."); 
}