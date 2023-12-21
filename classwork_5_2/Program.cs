char[] string_to_chars_array(string input_string)
{
    char [] output_array = new char [input_string.Length];
    for (int i = 0; i < input_string.Length; i++)
    {
        output_array [i] = input_string [i];
    }
    return output_array;
}

void ShowCharsArr(char [] chars)
{
    foreach(char elem in chars){
        Console.Write(elem + " ");
    }
}

string str = "Hello world!";
char [] crars_array =  string_to_chars_array(str);
ShowCharsArr(crars_array);