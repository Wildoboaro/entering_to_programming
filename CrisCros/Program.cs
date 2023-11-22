bool win = false;
int [,] steps = new int [3, 3];
string [] gamers = {"второй", "первый"};
int gamers_count = 1;
int step = 1;
while (!win | step == 9)
{
    if (gamers_count == 1)
    {
        gamers_count = 2;
    }
    else
    {
        gamers_count = 1;
    }
//     it just for test
//     Console.WriteLine(steps[0, 0]);
    bool ok = false;
    while (!ok)
    {
        Console.Write($"Ходит {gamers[gamers_count-1]} игрок. Введите номер клетки(в формате 'АB', где A номер столбца, a B номер строки):");
        int one_step = Convert.ToInt32(Console.ReadLine());
        if ((one_step % 10 == 1 | one_step % 10 == 2 | one_step % 10 == 3) & (one_step / 10 == 1 | one_step / 10 == 2 | one_step / 10 == 3))
        {
            if (steps[((one_step % 10)-1), ((one_step / 10)-1)] == 0)
            {
                ok = true;
                steps[((one_step % 10)-1), ((one_step / 10)-1)] = gamers_count;
            }
            else
            {
                Console.WriteLine("ЗАНЯТО!!!");
            }
        }
        else
        {
            Console.WriteLine("ХОД ЗА ПРЕДЕЛЫ ИГРОВОГО ПОЛЯ!!!");
        }
    }    
    if ((steps[0, 0] == steps[1, 0] & steps[1, 0] == steps[2, 0] & steps[0, 0] != 0) | 
        (steps[0, 1] == steps[1, 1] & steps[1, 1] == steps[2, 1] & steps[0, 1] != 0) |
        (steps[0, 2] == steps[1, 2] & steps[1, 2] == steps[2, 2] & steps[0, 2] != 0) |
        (steps[0, 0] == steps[0, 1] & steps[0, 1] == steps[0, 2] & steps[0, 0] != 0) |
        (steps[1, 0] == steps[1, 1] & steps[1, 1] == steps[1, 2] & steps[1, 0] != 0) |
        (steps[2, 0] == steps[2, 1] & steps[2, 1] == steps[2, 2] & steps[2, 0] != 0) |
        (steps[0, 0] == steps[1, 1] & steps[1, 1] == steps[2, 2] & steps[1, 1] != 0) |
        (steps[2, 0] == steps[1, 1] & steps[1, 1] == steps[0, 2] & steps[2, 0] != 0) )
    {
        win = true;
    }
    step = step + 1;
}
if (win)
{
    Console.Write($"Выиграл {gamers[gamers_count-1]} игрок");
}
else
{
    Console.Write("Ничья!");
}