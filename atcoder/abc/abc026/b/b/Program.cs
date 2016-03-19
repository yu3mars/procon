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
            int n = int.Parse(Console.ReadLine());
            int[] r = new int[n];
            for (int i = 0; i < n; i++)
            {
                r[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(r);
            Array.Reverse(r);
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) ans += r[i] * r[i];
                else ans -= r[i] * r[i];
            }
            Console.WriteLine(ans * Math.PI);
        }
    }
}
