        string str_minus(string str_input, int char_no)
        {
            string str_output = "";
            int count_ch = 0;
            while(count_ch < str_input.Length)
            {
                if (count_ch != char_no)
                {
                    str_output = str_output + str_input[count_ch];

                }
                count_ch = count_ch + 1;
            }
            return str_output;
        }
        
int count1 = 0;
int count_same;
int count2;
string str_out = "";
Console.Write("Введите строку: ");
string str = Console.ReadLine();
if (str.Length == 0)
{
    Console.Write("Строка пустая");
    return "";
}
else
{
    while (count1 < str.Length)
    {
//        cr = str[count1];
        count_same = 1;
        count2 = count1 + 1;
        while (count2 < str.Length)
        {
            if (str[count1] == str[count2])
            {
                count_same = count_same + 1;
                str = str_minus(str, count2);
            }
            else
            {
            count2 = count2 + 1;
            }
        }
        str_out = "'" + str[count1] + "'" + ": " + count_same;
        count1 = count1 + 1;
        if (count1 < str.Length)
        {
            str_out = str_out + ", ";
        }
        Console.Write(str_out);
    }
}