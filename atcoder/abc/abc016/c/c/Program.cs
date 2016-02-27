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
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            List<List<int>> friend = new List<List<int>>();
            for (int i = 0; i <= n; i++)
            {
                friend.Add(new List<int>());
            }
            for (int i = 0; i < m; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                friend[a].Add(b);
                friend[b].Add(a);
            }
            for (int i = 1; i <= n; i++)
            {
                SortedSet<int> cntset = new SortedSet<int>();
                foreach (int fre in friend[i])
                {
                    foreach (int frefre in friend[fre])
                    {
                        if (frefre != i && friend[i].Contains(frefre) == false)
                        {
                            cntset.Add(frefre);
                        }
                    }
                }
                int cnt = cntset.Count();
                Console.WriteLine(cnt);
            }
        }
    }
}
