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
            string[] ab = Console.ReadLine().Split(' ');
            int k = int.Parse(Console.ReadLine());
            string[] p = Console.ReadLine().Split(' ');
            SortedSet<string> s = new SortedSet<string>();
            for (int i = 0; i < 2; i++)
            {
                s.Add(ab[i]);
            }
            for (int i = 0; i < k; i++)
            {
                s.Add(p[i]);
            }
            if (s.Count == k + 2)
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
