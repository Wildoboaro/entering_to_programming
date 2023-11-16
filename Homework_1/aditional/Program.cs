// See https://aka.ms/new-console-template for more information
// Условный ввод значений
long a = 456;
long b = 782;
long c = 918;
// Выбор рабочего значерия
long n = c;
// Вычисление результата
long result = n / 100 + (n - ((n / 100) * 100 + ((n - ((n / 100) * 100)) / 10) * 10));
Console.WriteLine("Сумма первой и последней цифры числа " + n + " составляет: " + result);