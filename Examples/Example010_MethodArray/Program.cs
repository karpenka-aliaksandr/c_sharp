int [] array = {6,2,7,4,3,3,4,9};
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}