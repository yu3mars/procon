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
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long r = 0;
            for (long i = a; i <= b; i++)
            {
                r = (r + i * i * (i + 1) / 2) % 1000000007;
            }
            Console.WriteLine(r);
        }
    }
}
