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
            for (int j = 0; j < n; j++)
            {
                string s = Console.ReadLine();
                SortedDictionary<char, int> d = new SortedDictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (d.ContainsKey(s[i]) == true)
                    {
                        d[s[i]] += 1;
                    }
                    else
                    {
                        d.Add(s[i], 1);
                    }
                }
                if (d.Count == 6 && d['i'] == 1 && d['n'] == 2 && d['d'] == 2
                    && d['e'] == 2 && d['o'] == 1 && d['w'] == 1)
                {
                    Console.WriteLine("YES");
                }
                else Console.WriteLine("NO");
            }
        }
    }
}
