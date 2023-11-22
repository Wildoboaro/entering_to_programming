// Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
int[] array1 = [1, 2, 3, 4, 5, 6];
int[] array2 = [2, 5];
int [] array3 = new int [4];
int count1 = 0;
int count3 = 0;

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


// print result
count3 = 0;
while (count3 < array3.Length)
{
    Console.Write($"{array3[count3]} ");
    count3 = count3 + 1; 
}