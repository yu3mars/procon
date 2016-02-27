using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1316
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] hw = Console.ReadLine().Split(' ');
                int h = int.Parse(hw[0]);
                int w = int.Parse(hw[1]);
                if (h == 0) return;
                string[] map = new string[h];
                for (int i = 0; i < h; i++)
                {
                    map[i] = Console.ReadLine();
                }
                HashSet<string> set = new HashSet<string>();
                HashSet<string> ans = new HashSet<string>();
                int[] dx = new int[8] { -1, -1, -1, 0, 0, 1, 1, 1 };
                int[] dy = new int[8] { -1, 0, 1, -1, 1, -1, 0, 1 };

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            int nextx = i;
                            int nexty = j;
                            string tmp = "";
                            for (; ; )
                            {
                                tmp += map[nextx][nexty];
                                if (set.Contains(tmp))
                                {
                                    ans.Add(tmp);
                                }
                                else
                                {
                                    set.Add(tmp);
                                }
                                nextx = (nextx + dx[k] + h) % h;
                                nexty = (nexty + dy[k] + w) % w;
                                if (nextx == i && nexty == j) break;
                            }
                        }
                    }
                }

                string a = "0";
                foreach (string s in ans)
                {
                    if (a.Length < s.Length)
                    {
                        a = s;
                    }
                    else if (a.Length == s.Length)
                    {
                        if (s.CompareTo(a) < 0)
                        {
                            a = s;
                        }
                    }
                }
                if (a.Length < 2) a = "0";
                Console.WriteLine(a);
            }
        }
    }

}