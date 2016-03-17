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
            string[] lstr = Console.ReadLine().Split(' ');
            int[] l = new int[3];
            int soto = 0;
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                l[i] = int.Parse(lstr[i]);
                soto += l[i];
                max = Math.Max(max, l[i]);
            }
            int naka = Math.Max(0, max * 2 - soto);
            double ans = (soto * soto - naka * naka) * Math.PI;
            Console.WriteLine(ans);
        }
    }
}
