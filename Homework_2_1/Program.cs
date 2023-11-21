using System; 
using System.Linq;
 
namespace Homework_2_1; 
 
public static class Program 
{
 public static void Main()
 {
    int num;
    Console.Write("Введите введите число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if ((num % 7 == 0) & (num % 23 == 0))
    {
         Console.WriteLine("Да, число делется и на 7 и на 23");
    } 
    else
    {
     Console.WriteLine("Нет, это число не делится одновременно и на 7 и на 23");
// for additional checking
//        if ((num % 7 == 0))
//        {
//            Console.WriteLine("Число делется на 7, но не делится на 23");
//        }
//        else
//        {
//            if ((num % 23 == 0))
//            {
//                Console.WriteLine("Число не делется на 7, но делится на 23");
//            
//           }
//            else
//            {
//                Console.WriteLine("Число не делется на 7 м не делится на 23");       
//        }
//        }
    }
 }
}