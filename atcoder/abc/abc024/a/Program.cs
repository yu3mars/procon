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
            string[] abck = Console.ReadLine().Split(' ');
            int a = int.Parse(abck[0]);
            int b = int.Parse(abck[1]);
            int c = int.Parse(abck[2]);
            int k = int.Parse(abck[3]);
            string[] st = Console.ReadLine().Split(' ');
            int s = int.Parse(st[0]);
            int t = int.Parse(st[1]);
            int ans = a * s + b * t;
            if (s + t >= k) ans -= (s + t) * c;
            Console.WriteLine(ans);

        }
    }
}
