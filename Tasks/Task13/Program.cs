// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(int number)
{
    int thirdDigit = -1;
    int tempNumber = Math.Abs(number);
    if (tempNumber >= 100)
    {
        while (tempNumber >=1000)
        {
            tempNumber = tempNumber / 10;
        }
        thirdDigit = tempNumber % 10;
    }
    return thirdDigit;
}
Console.WriteLine("Введите число длиной до 10 знаков: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigit(number);
Console.WriteLine(thirdDigit >= 0 ?
$"Третья цифра числа {number} = {thirdDigit}":
$"В числе {number} - третьей цифры нет.");