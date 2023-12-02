// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

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

int [,] DelRowCol2dArray(int [,] input_array, int row, int col)
{
    int [,] output_array = new int [input_array.GetLength(0)-1,input_array.GetLength(1)-1];
    int i_n = 0;
    for(int i = 0; i<output_array.GetLength(0); i++)
    {    
        int j_n = 0;
        if (i == row)
        {
            i_n++;
        }
        for(int j=0; j<output_array.GetLength(1); j++)
        {
            if (j == col)
            {
                j_n++;
            }
            output_array[i,j]= input_array[i_n,j_n];
//            Console.WriteLine($"{i_n} - {i} , {j_n} -{j}");
            j_n++; 
        }
        i_n++;        
    }
    return output_array;
}

int[] MinNum2dArray(int [,] input_array)
{
    int [] output_array = {0,0};
    int min_num = input_array[0,0];
    for(int i = 0; i<input_array.GetLength(0); i++)
    {
        for(int j=0; j<input_array.GetLength(1); j++)
        {
            if (input_array[i,j] < min_num)
            {
                min_num = input_array[i,j];
                output_array[0] = i;
                output_array[1] = j;
            }
        }
    }
    return output_array;
}



int row = 5;
int col = 5;
int min = 1;
int max = 9;

int [,] work_array = Create2dArray(row,col,min,max);
Console.WriteLine("Начальный массив:");
Console.WriteLine();
Show2dArray(work_array);

//int no1 = 1;
//int no2 = 3;
int [] min_num_no = MinNum2dArray(work_array);

Console.WriteLine();
Console.WriteLine();
int [,] new_array = DelRowCol2dArray(work_array,min_num_no[0],min_num_no[1]);

Console.WriteLine($"Массив, полученный из начальнго, удалением сторкм {min_num_no[0]} и столбца {min_num_no[1]} (строки и столбца содердавших минимпльные элемент):");
Console.WriteLine();
Show2dArray(new_array);
