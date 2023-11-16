// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
long a = 456;
long b = 782;
long c = 918;
long n = c;
long result = n / 100 + (n - ((n / 100) * 100 + ((n - ((n / 100) * 100)) / 10) * 10));
Console.WriteLine(result);