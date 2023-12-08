using System.Xml.XPath;

int num = 617;
int first =  num / 10  % 10;
int last = num % 10;
int count = 1;
// double result = Math.Pow(first, last);
double result = first;
while (count < last)
{
    result = result * first;
    count = count + 1;
}
Console.WriteLine(result);
