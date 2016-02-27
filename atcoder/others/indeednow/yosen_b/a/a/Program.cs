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
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');
            int[] i1 = new int[2];
            int[] i2 = new int[2];
            int ans = 1;
            for (int i = 0; i < 2; i++)
            {
                i1[i] = int.Parse(s1[i]);
                i2[i] = int.Parse(s2[i]);
                ans += Math.Abs(i1[i] - i2[i]);
            }
            Console.WriteLine(ans);
        }
    }
}
