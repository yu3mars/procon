using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2155
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                if (n == 0 && m == 0) return;

                int ans = 1;
                bool[] infected = new bool[n + 1];
                infected[1] = true;
                SortedList<int, int> from = new SortedList<int, int>();
                SortedList<int, int> to = new SortedList<int, int>();
                for (int i = 0; i < m; i++)
                {
                    string[] tsd = Console.ReadLine().Split(' ');
                    int t = int.Parse(tsd[0]);
                    int s = int.Parse(tsd[1]);
                    int d = int.Parse(tsd[2]);
                    from.Add(t, s);
                    to.Add(t, d);
                }
                for (int i = 0; i < m; i++)
                {
                    int f = from.Values[i];
                    int t = to.Values[i];
                    if (infected[f] == true)
                    {
                        if (infected[t] == false)
                        {
                            infected[t] = true;
                            ans += 1;
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
