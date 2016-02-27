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
            char[] ca = Console.ReadLine().ToCharArray();
            char[] cb = Console.ReadLine().ToCharArray();
            char[] cc = Console.ReadLine().ToCharArray();
            int n = ca.Length / 2;
            int[] ia = new int[26];
            int[] ib = new int[26];
            int[] ic = new int[26];
            foreach (char c in ca)
            {
                ia[c - 'A'] += 1;
            } 
            foreach (char c in cb)
            {
                ib[c - 'A'] += 1;
            } 
            foreach (char c in cc)
            {
                ic[c - 'A'] += 1;
            }
            int amin = 0;
            int amax = 0;

            for (int i = 0; i < 26; i++)
            {
                amin += Math.Max(0, ic[i] - ib[i]);
                amax += Math.Min(ia[i], ic[i]);
            }
            if (amin <= n && n <= amax)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
