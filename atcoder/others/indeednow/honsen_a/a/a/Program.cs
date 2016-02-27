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
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] ls = new int[n];
            for (int i = 0; i < n; i++)
            {
                ls[i] = int.Parse(s[i]);
            }
            Array.Sort(ls);
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n / 2; i++)
            {
                int now = ls[i] + ls[n - 1 - i];
                max = Math.Max(max, now);
                min = Math.Min(min, now);
            }
            Console.WriteLine(max - min);
        }
    }
}
