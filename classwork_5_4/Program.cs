string FilterString(string input_string)
{
    string lower_string = input_string.ToLower();
    string output_string = "";
    foreach(char elem_str in lower_string)
    {
        if(elem_str != ' ')
        {
            output_string+=elem_str;
        }
    }
    return output_string;
}


bool IsPalindrome(string input_string)
{
    int len = input_string.Length;
    for (int i = 0; i < input_string.Length/2; i++)
    {
        if (input_string[i] != input_string[input_string.Length-i-1])
            return false;
    }
    return true;
}



string str = "Goig";
str = FilterString(str);
if (IsPalindrome(str)) 
Console.WriteLine("Полендром");
else
Console.WriteLine("Не полендром");