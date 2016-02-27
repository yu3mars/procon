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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int ab = 0;
            int ans = 0;
            if (a < 2 || b < 2)
            {
                ab = a + b;
            }
            else
            {
                ab = a * b;
            }
            if (ab < 2 || c < 2)
            {
                ans = ab + c;
            }
            else
            {
                ans = ab * c;
            }
            Console.WriteLine(ans);
        }
    }
}
