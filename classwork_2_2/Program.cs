// int NunCount(int division)
void NunCount(int division)
{
    int res  = 0;
    while (division > 0)
    {
        res = res + 1;
        division = division / 10; 
    }
    Console.WriteLine($"Количество цифр в числе равно {res}");
}
//    return res;
//}


Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
NunCount(Num);
// int Res = NunCount(Num);
// Console.WriteLine($"Количество цифр в числе {Num} равно {Res}");