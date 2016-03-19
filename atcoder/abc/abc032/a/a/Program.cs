using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = Lcm(a, b);
            if (n % l == 0) Console.WriteLine(n);
            else Console.WriteLine(n + l - n % l);
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
