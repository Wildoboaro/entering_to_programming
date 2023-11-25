int first = 4;
int second = 3;
if ((first % second) == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число не кратно второму, остаток от деления: {first % second}");    
}