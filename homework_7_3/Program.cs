// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void ArrayRevers (int[] arr)
{   
    if (arr.Length - 1 == 0)
    {
        Console.Write(arr[0]);
        return;
    }
    Console.Write(arr[arr.Length - 1] + " ");
    Array.Resize(ref arr, arr.Length - 1);
    ArrayRevers(arr);
}

int [] inputarray = {1, 2, 5, 0, 10, 34};

Console.Write("[" + string.Join(", ", inputarray) + "] => ");
ArrayRevers(inputarray);