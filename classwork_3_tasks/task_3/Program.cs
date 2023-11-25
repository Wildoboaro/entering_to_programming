int num = 14560;
int result;
if (num < 0)
{
    num *= (-1);
}
if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
    Console.WriteLine($"третья цифра c начала: {result}");
}