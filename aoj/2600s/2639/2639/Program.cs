using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2639
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int ans = -1;
            int sum = 0;

            while (sum <= Lcm(a + b, 60))
            {
                if (((sum % 60) <= c && c <= (sum % 60 + a)))
                {
                    ans = sum / 60 * 60 + c;
                    break;
                }
                sum += a + b;
            }
            
            Console.WriteLine(ans);
        }


        static int Lcm(int a, int b)
        {
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            return a * b / Gcd(a, b);
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
