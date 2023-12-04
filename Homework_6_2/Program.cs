// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string Change_Reg(string input_string)
{
    string output_string = "";
    for (int i = 0; i < input_string.Length; i++)
    {
        if (Char.IsLower(input_string[i]))
        {
            output_string = output_string + Char.ToUpper(input_string[i]);
        }
        else
        {
            output_string = output_string + Char.ToLower (input_string[i]);
        }
    }
    return output_string;
}


Console.Clear();
string str = "Hello World!";
string str_res =  Change_Reg(str);
Console.WriteLine(str_res);
