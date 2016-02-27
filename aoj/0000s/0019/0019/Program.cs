using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long ans = 1;
            for (int i = 2; i <= n; i++)
            {
                ans *= i;
            }
            Console.WriteLine(ans);
        }
    }
}
