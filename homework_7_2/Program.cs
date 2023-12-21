// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

bool Validation (int num1, int num2)
{
    bool result = true;
    if (num1 < 0 || num2 < 0) result = false;
    return result;
}

int Akkerdman(int num1, int num2)
{
    if (num1 == 0)
    {
        int result = num2 + 1;
        return result;
    }
    if (num2 == 0)
    {
        int result = Akkerdman(num1 - 1, 1);
        return result;
    }
    else
    {
        int result = Akkerdman(num1 - 1, Akkerdman(num1, num2 - 1));
        return result;
    }    
}

Console.Clear();

int m = 3;
int n = 5;

if (Validation(m, n))
{
    Console.WriteLine($"A({m}, {n}) = {Akkerdman(m, n)}");
}
else
{
    Console.WriteLine("Числа не соответвуют условиям.");    
}