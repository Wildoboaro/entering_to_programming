using System; 
using System.Linq;
 
namespace Homework_2_4; 
 
public static class Program 
{
 public static void Main()
{
    int count = 1;
    Console.WriteLine("Введеите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num_for_count = num;
    if (num > 9)
    {
        while ( (num_for_count / 10) > 10 )
        {
            num_for_count = num_for_count / 10;
            count++;
        }
 // this just for control
 //       Console.WriteLine(count);
        while (count > 0 )
        {
        Console.Write($"{(num / Convert.ToInt32(Math.Pow(10, count)))}, ");
        num = num - ((num / Convert.ToInt32(Math.Pow(10, count)))*Convert.ToInt32(Math.Pow(10, count)));
        count = count - 1;
        }
    }
    Console.Write(num);
}
}