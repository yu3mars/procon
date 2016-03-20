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
            string[] nst = Console.ReadLine().Split(' ');
            int n = int.Parse(nst[0]);
            int s = int.Parse(nst[1]);
            int t = int.Parse(nst[2]);
            int w = int.Parse(Console.ReadLine());
            int ans = 0;
            if (s <= w && w <= t) ans++;
            for (int i = 1; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                w += a;
                if (s <= w && w <= t) ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
