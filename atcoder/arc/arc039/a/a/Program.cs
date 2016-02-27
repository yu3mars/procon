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
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            int ans = a - b;
            int tmpa;
            int tmpb;
            for (int i = 1; i < 10; i += 8)
            {
                tmpa = a % 100 + i * 100;
                ans = Math.Max(ans, tmpa - b);

                tmpb = b % 100 + i * 100;
                ans = Math.Max(ans, a - tmpb);
            }
            for (int i = 0; i < 10; i += 9)
            {
                tmpa = a / 100 * 100 + a % 10 + i * 10;
                ans = Math.Max(ans, tmpa - b);

                tmpb = b / 100 * 100 + b % 10 + i * 10;
                ans = Math.Max(ans, a - tmpb);

                tmpa = a / 10 * 10 + i;
                ans = Math.Max(ans, tmpa - b);

                tmpb = b / 10 * 10 + i;
                ans = Math.Max(ans, a - tmpb);
            }
            Console.WriteLine(ans);
        }
    }
}
