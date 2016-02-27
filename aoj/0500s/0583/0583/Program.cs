using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0583
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] target = new int[n];
            int gcd = 1;
            for (int i = 0; i < n; i++)
            {
                target[i] = int.Parse(str[i]);
            }
            gcd = GetGcd(target[0], target[1]);
            if (n == 3)
            {
                gcd = GetGcd(target[2], gcd);
            }
            for (int i = 1; i <= gcd; i++)
            {
                if (gcd % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Sort(int a, int b)
        {
            if (a < b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
        }

        private static int GetGcd(int a, int b)
        {

            Sort(a, b);
            while (a % b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return b;
        }
    }
}
