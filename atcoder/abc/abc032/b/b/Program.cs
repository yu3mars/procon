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
            int k = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < s.Length - k + 1; i++)
            {
                set.Add(s.Substring(i, k));
            }
            Console.WriteLine(set.Count);
        }
    }
}
