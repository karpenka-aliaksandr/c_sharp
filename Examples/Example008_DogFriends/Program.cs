int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time;
while (distance>10) 
{
    if (friend == 1)
    {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(firstFriendSpeed+dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count ++;
}
Console.WriteLine($"Собака пробежит {count} раз.");