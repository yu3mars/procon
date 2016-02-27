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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] qstr = Console.ReadLine().Split(' ');
                int l = int.Parse(qstr[0]);
                int r = int.Parse(qstr[1]);
                string s1 = s.Substring(0, l - 1);
                string s2 = s.Substring(l - 1, r - l + 1);
                string s3 = s.Substring(r);
                char[] chr = s2.ToCharArray();
                Array.Reverse(chr);
                var s4 = new string(chr);
                s = s1 + s4 + s3;
            }
            Console.WriteLine(s);
        }
    }
}
