int FactorialFunc(int a)
{
    int product = 1;
    while (a > 1)
    {
        product = product * a;
        a = a - 1; 
    }
    return product;
}


Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Res = FactorialFunc(Num);
Console.WriteLine($"Произведение чисел от 1 до {Num} равна {Res}");