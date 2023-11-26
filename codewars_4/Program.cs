internal class Program
{
//    static Random random = new Random();
    private static void Main(string[] args)
    {
        int count = 0;
        int res = 0;

        //long b;
        //long m;
        long t;
        int random_number;

        long gcd(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return gcd(b, a % b);
            }
        }

        long mul(long a, long b, long m)
        {
            if (b == 1)
            {
                return a;
            }
            else
            {
                if (b % 2 == 0)
                {
                    t = mul(a, b / 2, m);
                    return 2 * t % m;
                }
                else
                {
                    return (mul(a, b - 1, m) + a) % m;
                }
            }
        }

        long pows(long a, long b, long m)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                if (b % 2 == 0)
                {
                    long t = pows(a, b / 2, m);
                    return mul(t, t, m) % m;
                }
                else
                {
                    return mul(pows(a, b - 1, m), a, m) % m;
                }
            }
        }


        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());


        if (n <= 1)
        {
            Console.WriteLine($"Число {n} меньше чам 2");
            //    return false;
        }
        else
        {
            if (n == 2)
            {
                Console.WriteLine($"Число {n} простое");
                //		return true;
            }
            else
            {
                //	srand(time(NULL));
                while (count < 100)
                {
  //                  random_number = random.Next(1, n);
                    random_number = new Random().Next(1,n);
                    long a = random_number % (n - 2) + 2;
                    if (gcd(a, n) != 1)
                    {
                        res = res + 1;
  //                      Console.WriteLine($"Число {n} соствное");
                        //			return false;			
                    }
                    else
                    {
                        if (pows(a, n - 1, n) != 1)
                        {
 //                           Console.WriteLine($"Число {n} соствное");
                            res = res + 1;
                            //           return false;			
                        }
//                        else
//                        {
//                            Console.WriteLine($"Число {n} простое");
                            //	        return true;
//                        }
                    }
                count = count + 1;
                }
                if (res > 0)
                {
                    Console.WriteLine($"Число {n} соствное");
//                    return false;
                }
                else
                {
                    Console.WriteLine($"Число {n} простое");
//                  return true;
                }
            }

        }
    }
}