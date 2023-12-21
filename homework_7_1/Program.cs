// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void NumFromTo (int start, int finish)
{
    if (finish == start)
    {
        Console.Write(start);
        return;
    }
    else
    {
        Console.Write(start + ", ");
        NumFromTo(start + 1, finish);
    }
}

int n = 1;
int m = 5;

if (n > m)
{
    int tempnum = n;
    n = m;
    m = tempnum;
}

NumFromTo(n, m);
