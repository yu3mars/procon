using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0007
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 100000;
            for (int i = 0; i < n; i++)
            {
                ans = ans / 100 * 105;
                ans = (ans + 999) / 1000 * 1000;
            }
            Console.WriteLine(ans);
        }
    }
}
