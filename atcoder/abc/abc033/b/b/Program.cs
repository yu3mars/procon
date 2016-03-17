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
            string[] s = new string[n];
            int[] p = new int[n];
            int pmax = 0;
            int nmax = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] sp = Console.ReadLine().Split(' ');
                s[i] = sp[0];
                p[i] = int.Parse(sp[1]);
                sum += p[i];
                if (p[i] > pmax)
                {
                    pmax = p[i];
                    nmax = i;
                }
            }
            if (pmax * 2 > sum)
            {
                Console.WriteLine(s[nmax]);
            }
            else Console.WriteLine("atcoder");
        }
    }
}
