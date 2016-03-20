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
            string s = Console.ReadLine();
            string[] astr = Console.ReadLine().Split(' ');
            int[] a = new int[6];
            a[0] = 0;
            a[5] = s.Length;
            string ans = "";
            for (int i = 1; i < 5; i++)
            {
                a[i] = int.Parse(astr[i - 1]);
                ans += s.Substring(a[i - 1], a[i] - a[i - 1])+"\"";
            }
            ans += s.Substring(a[4]);
            Console.WriteLine(ans);
        }
    }
}
