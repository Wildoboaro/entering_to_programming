// Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
// data for test
int[] array1 = [1, 2, 2, 2, 5, 6, 1, 25, 16, 256];
int[] array2 = [2, 5, 25];

    static int[] ArrayDiff(int[] a, int[] b)
    {
        // founding diff arroy size
        int count1 = 0;
        int count3 = 0;
        int same_size = a.Length;
        while (count1 < a.Length) 
        {
            bool dif = true;
            int count2 = 0;
            while (count2 < b.Length)
            {
                if (a[count1] == b[count2])
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
        //Console.WriteLine($"Количество одинаковых элементов: {same_size}");

        int [] a3 = new int [a.Length - same_size];
        count1 = 0;
        count3 = 0;
        // creating diff array

        while (count1 < a.Length) 
        {
            bool dif = true;
            int count2 = 0;
            while (count2 < b.Length)
            {
                if (a[count1] == b[count2])
                {
                    dif = false;
                }
                count2 = count2 + 1;
            }
            if (dif)
            {
                a3[count3] = a[count1];
                count3 = count3 + 1;
            }
           
            count1 = count1 + 1;
        }
        return a3;
    }

// printing result
int[] array_diff = ArrayDiff(array1, array2); 
int  count_print = 0;
while (count_print < array_diff.Length)
{
    Console.Write($"{array_diff[count_print]} ");
    count_print = count_print + 1; 
}