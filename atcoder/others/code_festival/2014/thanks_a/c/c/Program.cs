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
            string[] nm = Console.ReadLine().Split(' ');
            string[] pstr = Console.ReadLine().Split(' ');
            string[] sstr = Console.ReadLine().Split(' ');
            int ans = 0;
            foreach (string s in sstr)
            {
                ans += int.Parse(pstr[int.Parse(s) - 1]);
            }
            Console.WriteLine(ans);
        }
    }
}
