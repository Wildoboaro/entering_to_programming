// int[] array = { 1, 2, 3, 4, 5, 67, 78, 88, 67 };
// int n = array.Length;
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collect, int find)
{
    int ct = collect.Length;
    int ix = 0;
    int position = -1;
    while(ix < ct)
    {
        if (collect[ix] == find)
        {
            position = ix;
            break;
        }
        ix++;
    }
    return position;
}

int [] array = new int[10];
FillArray(array);
PrintArray(array);

int find;
Console.Write("Введите искомое число: ");
find = Convert.ToInt32(Console.ReadLine());

int pos = IndexOf(array, find);

// Console.Write(pos);
if (pos == -1)
{
    Console.Write($"Элемент равный {find} не наайден в этом массиве");
} 
else
{
    Console.Write($"Номер элемента массива равного {find}: {pos}");
}