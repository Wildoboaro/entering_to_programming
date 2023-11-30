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

int [,] found_min_2d_array (int [,] array_input)
{
    int [,] array_output = new int [array_input.GetLength(0), array_input.GetLength(1)];
    int row = 0;
    int col = 0;
    int min = array_input[row, col];
    for (int i = 0; i<array_input.GetLength(0); i++)
    {
        for(int j = 0; j<array_input.GetLength(1);j++)
        {
            if (array_input[i,j] < min)
            {
                row = i;
                col = j;
                min = array_input[row, col];
            }
        }
    }
//  it just for test
    // Console.WriteLine();
    // Console.WriteLine(min);
    // Console.WriteLine();
    // Console.WriteLine(row);
    // Console.WriteLine(col);
    // Console.WriteLine();
    for (int i =0; i<array_input.GetLength(0); i++)
    {
        for(int j = 0; j<array_input.GetLength(1);j++)
        {
            if (i==row | j == col)
            {
                array_output[i,j] = 0;
            }
            else 
            {
                array_output[i,j] = array_input[i,j];
            } 
        }
    }
    
    return array_output;
    
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
int [,] new2dArray = found_min_2d_array(created2dArray);
Show2dArray(new2dArray);