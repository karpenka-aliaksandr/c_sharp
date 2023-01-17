bool Question_one(int[] a) {
        a[0]=20;
        return false;  }
bool Question_two(int[] a) {
        a[0]=30;
        return true; }

int[] a = {10};
if (Question_one(a) && Question_two(a)) {
        Console.WriteLine("Условие && выполнилось"); }
Console.WriteLine("&& a[0]="+a[0]);
a[0] = 10;
if (Question_one(a) & Question_two(a)) {
        Console.WriteLine("Условие && выполнилось"); }
Console.WriteLine("& a[0]="+a[0]);
a[0] = 10;
if (Question_two(a) || Question_one(a)) 
    {
        Console.WriteLine("Условие || выполнилось");
    }
Console.WriteLine("|| a[0]="+a[0]);
a[0] = 10;
if (Question_two(a) | Question_one(a)) 
    {
        Console.WriteLine("Условие | выполнилось");
    }
Console.WriteLine("| a[0]="+a[0]);