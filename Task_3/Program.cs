// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int i1 = 21;
int i2 = 3;
int i3 = 17;
int i4 = 5;
long l1 = 7;
double d1 = 8.9;
  int sum = i1 + i2;
  long sum_l = i1 + l1;
  double sum_d = i1 + d1;  

  int product = i1 * i2;
  long product_l = i1 * l1;
  double product_d = i1 * d1;  

  int quotient = i1 / i2;
  long quotient_l = i1 / l1;
  double quotient_d = i1 * d1;  
  int a = i1;
  int b = i2;
  int c = i3;
  int d = i4;
  double result = (a * b)/(c + d);
Console.Write("Сумма простых чисел: ");
Console.WriteLine(sum);
Console.Write("Сумма простого м целочисденного: ");
Console.WriteLine(sum_l);
Console.Write("Сумма простого и числа с дробной частью: ");
Console.WriteLine(sum_d);
Console.Write("Произведение простых чисел: ");
Console.WriteLine(product);
Console.Write("Произведение простого м целочисденного: ");
Console.WriteLine(product_l);
Console.Write("Произведение простого и числа с дробной частью: ");
Console.WriteLine(product_d);
Console.Write("Результат деления простых чисел: ");
Console.WriteLine(quotient);
Console.Write("Результат деления простого на целочисденное: ");
Console.WriteLine(quotient_l);
Console.Write("Результат деления простого на числа с дробной частью: ");
Console.WriteLine(quotient_d);

Console.Write("Результат вычисления формулы (a * b)/(c + d): ");
Console.WriteLine(result);
