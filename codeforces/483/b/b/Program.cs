using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int cx = int.Parse(str[0]);
            int cy = int.Parse(str[1]);
            int x = int.Parse(str[2]);
            int y = int.Parse(str[3]);
            
            long xylcm = Lcm(x, y);
            long sum = cx + cy;
            long add = sum / xylcm;
            if (sum / x > cy)
            {
                add += sum / x - cy;
            }
            if (sum / y > cx)
            {
                add += sum / y - cx;
            }

            long ans = cx + cy + add;
            Console.WriteLine(ans);
        }


        static long Lcm(int a, int b)
        {
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            return (long)a * (long)b / (long)Gcd(a, b);
        }

        static int Gcd(int a, int b)
        {
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            if (b == 0)
            {
                return a;
            }
            else return (Gcd(b, a % b));
        }
    }
}
