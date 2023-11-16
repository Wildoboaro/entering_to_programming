// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int a = 3;
int b = 8;
int c = 11;
int d = 1;
int e = 6;
int max = a;
// if (a > b)
if (b > max)
{
//    Console.Write("Большее из чисел: ");
//    Console.WriteLine(a);
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
// else
//{
//    Console.Write("Большее из чисел: ");
//    Console.WriteLine(b);
//}
Console.Write("Большее из чисел: ");
Console.WriteLine(max);
