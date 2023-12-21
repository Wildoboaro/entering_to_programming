// вывести натуральные числа  от 1 до N

void IntNum (int num)
{
    if (num > 0)
    {
        IntNum (num - 1);
        Console.Write (num + " ");
    }
    
}
int N = 5;
IntNum (N);