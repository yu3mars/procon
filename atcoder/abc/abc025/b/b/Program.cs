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
            string[] nab = Console.ReadLine().Split(' ');
            int n = int.Parse(nab[0]);
            int a = int.Parse(nab[1]);
            int b = int.Parse(nab[2]);
            int ans = 0;//east=+,west=-.
            for (int i = 0; i < n; i++)
            {
                string[] sd = Console.ReadLine().Split(' ');
                int d = int.Parse(sd[1]);
                d = Math.Max(d, a);
                d = Math.Min(d, b);
                if (sd[0] == "West")
                {
                    d = -d;
                }
                ans += d;
            }
            if (ans == 0) Console.WriteLine(0);
            else if (ans > 0) Console.WriteLine("East {0}", ans);
            else if (ans < 0) Console.WriteLine("West {0}", -ans);
        }
    }
}
