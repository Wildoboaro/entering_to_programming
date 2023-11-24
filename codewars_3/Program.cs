// 1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
// 5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)


Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2;
string res = "";
if (sum / 2 == 1)
{
    res = "10";
}
else
{
while ((sum / 2) !=1 )
{
    sum = (sum / 2) + (sum % 2);
    res = res + sum / 2;    
}
res = res + sum / 2;
}
Console.Write(res);