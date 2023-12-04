int GetCountVovelsInString(string str1, string str2)
{
int count = 0;
foreach(char str1_elem in str1)
{
    foreach(char str2_elem in str2)
    {
        if(str1_elem == str2_elem)
        {
            count++;
        }
    }
}
return count;
}


string str1 = "world";
string str2 = "wrtgfhjdid";
int count = GetCountVovelsInString(str1, str2);
Console.WriteLine(count);