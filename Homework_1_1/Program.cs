
// мои дополнения
int firstNumber;
int secondNumber;
Console.Write("Введите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
// домашка 1 часть 1
// Контрольный вывод переменных на экран
//Console.WriteLine($"firstNumber: '{firstNumber}'");
//Console.WriteLine($"secondNumber: '{secondNumber}'");
// Решение
if (firstNumber < secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
else
if (firstNumber > secondNumber)
{
    Console.WriteLine($"Второе число `{secondNumber}` меньше чем первое число `{firstNumber}`");
}
else
{
    Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}