Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine($"Число {n} меньше единцы");
//    return false;
} 
else
{
    int s = 4;
    int k = 1;
    int m = Convert.ToInt32(Math.Pow(2, n)) - 1;
    while (k != n - 1)
    {
        s = ((s * s) - 2) * m;
        k += 1;
    }
    if (s == 0)
    {
        Console.WriteLine($"Число {n} простое");
//    return true;
    } 
    else
    { 
        Console.WriteLine($"Число {n} соствное");
//    return false;
    }

}
