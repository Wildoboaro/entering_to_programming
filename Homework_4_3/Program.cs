// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] ReversArray(int[] array_input)
{
    int [] array_output = new int [array_input.Length];
    for (int i = 0; i < array_input.Length; i++)
    {
        array_output[i] = array_input[(array_input.Length -1) - i];
    }
    return array_output;
}

int[] array = MakeArray(1, 100, 10);

PrintArray(array);

Console.WriteLine();

int[] array2 = ReversArray(array);

Console.WriteLine();

PrintArray(array2);