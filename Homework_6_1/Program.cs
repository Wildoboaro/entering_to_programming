// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string Chars2dArrayToString(char[,] array_input)
{
    string output_string = "";
    for (int i=0; i < array_input.GetLength(0); i++)
    {
        for (int j=0; j < array_input.GetLength(1); j++)
        {
            output_string = output_string + array_input[i,j] + " ";
        }
    }
    return output_string;
}

Console.Clear();
char [,] chars_array = {{'a','b','c'},{'d','e','f'},{'g','j','h'}};
string str = Chars2dArrayToString(chars_array);
Console.WriteLine(str);