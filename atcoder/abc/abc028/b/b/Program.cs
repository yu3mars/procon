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
            string s = Console.ReadLine();
            int[] ans = new int[6];
            for (int i = 0; i < s.Length; i++)
            {
                ans[s[i] - 'A']++;
            }
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
