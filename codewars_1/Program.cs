// Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}

int[] array1 = [1, 2, 2, 2, 5, 6];
int[] array2 = [2, 5];
// int [] array3 = new int [4];

int count1 = 0;
int count3 = 0;
function int[] Kata.ArrayDiff(int[], int[]);
{
// founding diff  arroy size
int same_size = array1.Length;
while (count1 < array1.Length) 
{
    bool dif = true;
    int count2 = 0;
    while (count2 < array2.Length)
    {
        if (array1[count1] == array2[count2])
        {
            dif = false;
        }
        count2 = count2 + 1;
    }
    if (dif)
    {
        same_size = same_size - 1;
        count3 = count3 + 1;
    }
           
    count1 = count1 + 1;
}

// it just  for testing
Console.WriteLine($"Количество одинаковых элементов: {same_size}");

int [] array3 = new int [array1.Length - same_size];
count1 = 0;
count3 = 0;
// creating diff array

while (count1 < array1.Length) 
{
    bool dif = true;
    int count2 = 0;
    while (count2 < array2.Length)
    {
        if (array1[count1] == array2[count2])
        {
            dif = false;
        }
        count2 = count2 + 1;
    }
    if (dif)
    {
        array3[count3] = array1[count1];
        count3 = count3 + 1;
    }
           
    count1 = count1 + 1;
}
return array3;
}

// printing result
int[] array_diff = Kata.ArrayDiff(array1, array2); 
count3 = 0;
while (count3 < array_diff.Length)
{
    Console.Write($"{array_diff[count3]} ");
    count3 = count3 + 1; 
}