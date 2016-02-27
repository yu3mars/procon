using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITP1_2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] l = new int[3];
            for (int i = 0; i < 3; i++)
            {
                l[i] = int.Parse(s[i]);
            }
            Array.Sort(l);
            for (int i = 0; i < 3; i++)
            {
                s[i] = l[i].ToString();
            }
            string ans = string.Join(" ", s);
            Console.WriteLine(ans);
        }
    }
}
