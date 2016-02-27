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
            char[] chr = Console.ReadLine().ToCharArray();
            int[] ls = new int[chr.Length];
            int ans = 0;
            for (int i = 0; i < chr.Length; i++)
            {
                ls[i] = int.Parse(chr[i].ToString());
                if (i % 2 == 0)
                {
                    ans += ls[i];
                }
                else
                {
                    ans -= ls[i];
                }
            }
            Console.WriteLine(ans);
        }
    }
}
