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
            int ans = 0;
            SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (set.Contains(a)) ans++;
                else set.Add(a);
            }
            Console.WriteLine(ans);
        }
    }
}
