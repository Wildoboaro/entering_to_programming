
int [,] Create2dArray(int row, int col, int min, int max)
{
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++)
    {
        for(int j = 0; j<col;j++)
        {
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

// void Show1dArray(int [] array)
// {
//     for(int i = 0; i<array.GetLength; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
// }


int Count2dDiag(int [,] array)
{
    int count = 0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(i==j)
            {
   //       it just for test
   //           Console.Write(array[i,j] + " ");
              count = count + array[i,j];
            }
            
        }
    }
    return count;
}


Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);
Show2dArray(created2dArray);
Console.WriteLine();
int count = Count2dDiag(created2dArray);
Console.WriteLine(count);