// The Challenge:

// Your code must return true or false (not 'true' and 'false') depending upon whether the given number is a Narcissistic number in base 10.

// This may be True and False in your language, e.g. PHP.

// Error checking for text strings or other invalid inputs is not required, only valid positive non-zero integers will be passed into the function.



Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = num_f; 
// bool Narcissistic(int value)
// calculation
bool res;
int calc = 0;
int quantity_num = 0;
int quantity_num_tmp1 = num;
int degree;
int num_in_dig;
while (quantity_num_tmp1 > 0)
{
    quantity_num++; 
    quantity_num_tmp1 /= 10;
// just fpr test
//    Console.Write(quantity_num);
}
// just fpr test
// Console.Write(quantity_num);
    quantity_num_tmp1 = num;
    int quantity_num_tmp2 = quantity_num;
    while (quantity_num_tmp2 > 0) 
    {
      degree = quantity_num;
      num_in_dig = 1;
      while (degree > 0)
      {
          num_in_dig = num_in_dig * (quantity_num_tmp1 % 10);
          degree = degree - 1; 
// just fpr test
//          Console.Write($"{num_in_dig} ");
//          Console.Write($"{quantity_num_tmp1 % 10} ");
      }
      
      calc = calc + num_in_dig;
      quantity_num_tmp1 /= 10 ;
      quantity_num_tmp2--;
// just fpr test
//Console.WriteLine(quantity_num_tmp1);
// Console.WriteLine(calc);
}
// just fpr test
//Console.WriteLine(calc);
//Console.WriteLine(num);
// analise
if (num == calc)
{
    res = true;
//    return true;
}
else
{
    res = false;
//    return false;
}

Console.Write(res);