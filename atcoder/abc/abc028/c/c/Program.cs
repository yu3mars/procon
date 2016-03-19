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
            string[] st = Console.ReadLine().Split(' ');
            int[] s = new int[5];
            for (int i = 0; i < 5; i++)
            {
                s[i] = int.Parse(st[i]);
            }
            Console.WriteLine(Math.Max(s[0] + s[3] + s[4], Math.Max(s[1] + s[2] + s[3], s[1] + s[2] + s[4])));
        }
    }
}
