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
            string[] s = Console.ReadLine().Split(' ');
            long a = long.Parse(s[0]);
            long b = long.Parse(s[1]);
            long ans=0;
            if ((a > 0 && b > 0) || (a < 0 && b < 0)) ans = Math.Abs(a - b);
            else ans = Math.Abs(a - b) - 1;
            Console.WriteLine(ans);
        }
    }
}
