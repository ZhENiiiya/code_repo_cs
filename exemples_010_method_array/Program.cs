int[] array = {12, 5, 34, 22, 100, 27, 94,  45, 100};

int n = array.Length;
int find = 100;

int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
