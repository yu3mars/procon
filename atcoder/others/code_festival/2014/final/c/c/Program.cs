using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long begin = 10;
            long end = 10000;
            for (long i = begin; i <= end; i++)
            {
                char[] chr = i.ToString().ToCharArray();
                int[] ls = new int[chr.Length];
                long ans = 0;
                for (int j = 0; j < chr.Length; j++)
                {
                    ls[j] = int.Parse(chr[j].ToString());
                    ans += ls[j] * (long)Math.Pow(i, chr.Length - 1 - j);
                }
                if (a == ans)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("-1");
        }
    }
}
