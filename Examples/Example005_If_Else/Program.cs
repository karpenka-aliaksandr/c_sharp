Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine()!;
if (userName.ToLower() == "саша")
{
    Console.WriteLine("Ура, это Саша!");
}
else
{
    Console.WriteLine($"Привет, {userName}");
}

