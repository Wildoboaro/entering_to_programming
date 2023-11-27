﻿// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

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

int[] array = MakeArray(1, 100, 10);

PrintArray(array);

Console.WriteLine();

int calc = CalcEvenElement(array);

Console.WriteLine();

Console.WriteLine($"Количество четных элементов массива {calc}");