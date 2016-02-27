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
            string[] str = Console.ReadLine().Split(' ');
            ulong n = ulong.Parse(str[0]);
            ulong m = ulong.Parse(str[1]);
            ulong cmin = m;
            ulong cmax = m;
            for (ulong i = 0; i < n; i++)
            {
                ulong cx = ulong.Parse(Console.ReadLine());
                cmin = Math.Min(cmin, cx);
                cmax = Math.Max(cmax, cx);
            }
            Console.WriteLine(cmax - cmin);
        }
    }
}
