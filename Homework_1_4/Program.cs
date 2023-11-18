// мои дополнения
int number;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
// Контрольный вывод переменных на экран
// Console.WriteLine($"number:  '{number}'");
// решение
int evenNumber = 2;
while (evenNumber <= number)
{
    Console.Write($"{evenNumber}	");
    evenNumber = evenNumber + 2;
}