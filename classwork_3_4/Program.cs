void SqrsFunc(int a)
{
    int sqrs = 1;
    if (a == 0)
    {    
        Console.Write("вы ввели ноль");
    }
    else
    {
        Console.Write(sqrs);
        if (a > 1)
        {
            while (sqrs < a)
            {
                sqrs = sqrs + 1;
                Console.Write($", {sqrs*sqrs}");
            }
        }
    }
}


Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
SqrsFunc(Num);
