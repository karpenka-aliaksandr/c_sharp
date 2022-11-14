// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string ConvertDecToBinary(int dec)
// {
//     string binary = string.Empty;
//     while (dec>0)
//     {
//         binary = Convert.ToString(dec % 2) + binary;
//         dec /= 2;
//     }
//     return binary;
// }

// Console.Write ("Введите десятичное число: ");
// int numberDec = Convert.ToInt32(Console.ReadLine());
// string numberBinary = ConvertDecToBinary(numberDec);
// Console.WriteLine($"Десятичное число {numberDec} будет в двоичном представлении выглядеть как: {numberBinary}.");


int ConvertDecToBinary(int dec)
{
    if (dec == 0) return 0;
    if (dec == 1) return 1;
    return ConvertDecToBinary(dec/2) * 10 + dec % 2;
}

Console.Write ("Введите десятичное число: ");
int numberDec = Convert.ToInt32(Console.ReadLine());
int numberBinary = ConvertDecToBinary(numberDec);
Console.WriteLine($"Десятичное число {numberDec} будет в двоичном представлении выглядеть как: {numberBinary}.");