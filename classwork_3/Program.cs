int num = 785;
int first = num / 100;
int last = num % 10;
// первый варинт вывода результата
int result = first * 10 + last;
Console.WriteLine(result);
// второй вариант вывода результата
Console.WriteLine($"{first}{last}");