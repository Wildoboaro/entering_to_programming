// мои дополнения
int number;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
// Контрольный вывод переменных на экран
Console.WriteLine($"number:  '{number}'");
// решение мое
// if ((number/2)*2 == number)
//{
//    Console.WriteLine($"Число `{number}` чётное");
//}
//else
//{
//    Console.WriteLine($"Число `{number}` нечётное");
//}
// решение "правильное"
if (number % 2 == 0)
{
    Console.WriteLine($"Число `{number}` чётное");
}
else
{
    Console.WriteLine($"Число `{number}` нечётное");
}