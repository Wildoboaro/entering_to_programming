//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int Summ_num (int num_input)
{
    int num_output = 1;
    if (num_input/100 == 0 & num_input >= 10)
    {
        num_output = (num_input / 10) + (num_input % 10);
    }
//    else
//    {
//        Console.WriteLine("Число не является двухзначным");
//        System.Threading.Thread.Sleep(2000);
//    }
    return num_output;
}
bool i = true;
int num_input;

while (i)
{
    Console.Write("Введите целое двухзачное число, сумма цифр в кором четна или q для выхода :");
    string  str_input = Console.ReadLine();
    if (str_input == "q")
    {
        Console.WriteLine("Вы вышли из программы.");
        break;
    }
    num_input = Convert.ToInt32(str_input);
// it just for test
//    Console.WriteLine(num_input);
//    Console.WriteLine((Summ_num (num_input)));
    
    if ((Summ_num (num_input)) % 2 == 0)
    {
        Console.WriteLine("Вы ввели число удовлетворяюще требованиям.");
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели число неудовлетворяюще требованиям.");
        System.Threading.Thread.Sleep(2000);
    }
    Console.Clear();
}