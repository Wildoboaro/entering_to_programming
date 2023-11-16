// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int a = 1;
int b = 4;

if (a == b * b)
{
    Console.WriteLine((a) + " является квадаратом " + (b));
}
else
if (b == a * a)
{
    Console.WriteLine((b) + " является квадаратом " + (a));
}
else
{
    Console.WriteLine("Ни одно из чисел указанных не является квадаратом второго");
}



int c = 4;
int count = -c;

while (count <= c)
{
    Console.Write(count);
    Console.Write(' ');
    count++;
}
