// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string ReverssSentence(string input_string)
{
    string output_string = "";
    string one_world = "";
    for (int i = 0; i < input_string.Length; i++)
    {
        if (input_string[i] != ' ')
        {
            one_world = one_world + (input_string[i]);
        }
        else
        {
            output_string = one_world + ' ' + output_string;
            one_world = "";
        }
    }
    output_string = one_world + ' ' + output_string;
    return output_string;
}

Console.Clear();
string str = "I'd like to have a method that reverse the sentence";
string str_res =  ReverssSentence(str);
Console.WriteLine(str_res);