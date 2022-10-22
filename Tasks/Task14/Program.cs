// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Multiple(int dividend, int divider)
{
return dividend % divider == 0;
}

Console.WriteLine("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());
int divider1 = 7;
int divider2 = 23;

Console.WriteLine((Multiple(num, divider1) && Multiple(num, divider2)) ? "да" : "нет");


