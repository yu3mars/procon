using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTL_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(str[i]);
            }
            int ans = 1;
            for (int i = 0; i < n; i++)
            {
                ans = Lcm(ans, num[i]);
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

            return a*b/Gcd(a,b);
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
