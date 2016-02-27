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
            string s = Console.ReadLine().ToUpper();
            SortedSet<char> set = new SortedSet<char>();
            for (int i = 0; i < n; i++)
            {
                set.Add(s[i]);
            }
            if (set.Count == 26)
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
