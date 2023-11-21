using System; 
using System.Linq;
 
namespace Homework_2_3; 
 
public static class Program 
{
 public static void Main()
 {
  int num = 0;
  int max;
  while( num < 10 | num > 90)
  {
   Console.Write("Введите двухзначное число: ");
   num = Convert.ToInt32(Console.ReadLine());
  }
  if ((num  / 10) == (num % 10))
  {
   Console.WriteLine($"Число состоит из одиаковых цифр: {num / 10}");
  }
  else
  {
   if ( num / 10 > num % 10)
   {
    max = num /10;
   }
   else
   {
    max = num % 10;
   }
  Console.WriteLine($"Большая цифра из состовляющих число: {max}"); 
  }
 } 
}