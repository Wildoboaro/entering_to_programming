// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 

//Указание
//Конструктор строки вида string(char []) не использовать.


// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”



string chars_array_to_string(char[] input_array)
{
    string output_string = "";
    foreach (char elrment_array in input_array)
    {
        output_string = output_string + elrment_array + " ";
    }
    return output_string;
}

char [] chars_array = {'a', 'b', 'c', 'd', 'e', 'f'};
string str =  chars_array_to_string(chars_array);
Console.WriteLine(str);