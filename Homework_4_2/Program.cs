// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] MakeArray(int min, int max, int size)
{
    int num;
    int [] array_output = new int [size];
    for (int i = 0; i < size; i++)
    {
        num = new Random().Next(min,max+1);
        array_output[i] = num;
    }
    return array_output;
}

void PrintArray(int[] array_input)
{
    for (int i = 0; i < array_input.Length; i++)
    {
        Console.Write($"{array_input[i]} ");
    }
}

int CalcEvenElement(int[] array_input)
{
    int calc = 0;
    for (int i = 0; i < array_input.Length; i++)
    {
        if ((array_input[i]) % 2 == 0)
        {
            calc++;
//            it just for test
//            Console.Write($"{array_input[i]} ");
        }
    }
    return calc;
}

int[] MakeEvenElementArray(int[] array_input, int size)
{
    int [] array_output = new int [size];
    int calc_no = 0;
    for (int i = 0; i < array_input.Length; i++)
    {
        if ((array_input[i]) % 2 == 0)
        {
            array_output[calc_no] = array_input[i];
            calc_no++;
//            it just for test
//            Console.Write($"{array_input[i]} ");
        }
    }
    return array_output;
}

int[] array = MakeArray(100, 999, 10);

PrintArray(array);

Console.WriteLine();

int calc = CalcEvenElement(array);

Console.WriteLine();

Console.WriteLine($"Количество четных элементов массива {calc}");

int[] array2 = MakeEvenElementArray(array, calc);

PrintArray(array2);