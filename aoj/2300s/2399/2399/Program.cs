using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2399
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                string[][] m = new string[n][];
                for (int i = 0; i < n; i++)
                {
                    m[i] = Console.ReadLine().Split(' ');
                }
                string[] roei = Console.ReadLine().Split(' ');
                HashSet<string> roeils = new HashSet<string>();
                for (int i = 1; i < roei.Length; i++)
                {
                    roeils.Add(roei[i]);
                }
                int ans = -1;
                for (int i = 0; i < n; i++)
                {
                    HashSet<string> yougi = new HashSet<string>();
                    for (int j = 1; j < m[i].Length; j++)
                    {
                        yougi.Add(m[i][j]);
                    }
                    yougi.IntersectWith(roeils);
                    if (yougi.Count == roeils.Count)
                    {
                        if (ans == -1)
                        {
                            ans = i + 1;
                        }
                        else
                        {
                            ans = -1;
                            break;
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
