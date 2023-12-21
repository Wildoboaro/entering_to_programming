// Принимает стороку, выводит согасные из неё 

void ShowConsanant(string str)
{    
    if (str.Length == 0) return;
    string standart = "qwrtpsdfghklzxcvbnm";
    if (standart.Contains(char.ToLower(str[0])))
    {
        Console.Write(str[0]+ " ");
    }
    ShowConsanant(str.Substring(1));
}

Console.Clear();
ShowConsanant("World");