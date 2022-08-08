int[] array = { 12, 26, 84, 20, 1, 3, 47, 15, 20 };

int n = array.Length;
int find = 20;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}