// мои дополнения
int a;
int b;
int c;
Console.Write("Введите первое число:  ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе третье: ");
c = Convert.ToInt32(Console.ReadLine());
// домашка 1 часть 1
// Контрольный вывод переменных на экран
//Console.WriteLine($"firstNumber:  '{a}'");
//Console.WriteLine($"secondNumber: '{b}'");
//Console.WriteLine($"thirdNumber:  '{c}'");
// Решение
int result = a;
if (b > result)
{
    result = b;
}
if (c > result)
{
    result = c;
}
// Console.WriteLine($"Максимальоне число:   '{result}'");
return result;