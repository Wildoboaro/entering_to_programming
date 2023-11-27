// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

int [] ArrayFromNumber(int num)
{
    int num_for_calc = num;
    int count = 0;
    while (num_for_calc > 0)
    {
        count++;
        num_for_calc = num_for_calc / 10; 
    }
    int [] array_output = new int [count]; 
    for(int i = 0; i < count; i++)
    {
        array_output[count-(i+1)] = num % 10;
        num = num / 10;
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


int num = new Random().Next(1, 100000);

Console.WriteLine($"Число: {num}");

int[] array = ArrayFromNumber(num);

Console.Write("Массив: ");
PrintArray(array);

