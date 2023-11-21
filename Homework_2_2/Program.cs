using System; 
using System.Linq;
 
namespace Homework_2_2; 
 
public static class Program 
{
 public static void Main()
 {
  int x;
  int y;
  Console.Write("Введите координату X:");
  x = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите координату Y:");
  y = Convert.ToInt32(Console.ReadLine());
  if ( x == 0 & y == 0 )
  {
   Console.WriteLine("Точка лежит на переснчении оси координат");   
  }
  else
  {
  if ( x == 0 )
  { 
   Console.WriteLine("Точка лежит на оси Y");
  }
  if ( y == 0 )
  {
   Console.WriteLine("Точка лежит на оси X"); 
  }
  if ( x > 0 & y > 0)
  {
  Console.WriteLine("Точка лежит в первой четверти стстемы коодинат");  
  }
  if ( x > 0 & y < 0)
  {
  Console.WriteLine("Точка лежит во вторй четверти систмы координат"); 
  }
  if ( x < 0 & y < 0)
  {
  Console.WriteLine("Точка лежит в третьей четверти системы коордтнат"); 
  }
  if ( x < 0 & y > 0)
  {
  Console.WriteLine("Точка лежит в четвертой четверти системы кооржинат");  
  }
  }  
 } 
}
