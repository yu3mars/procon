using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1126
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] wh = Console.ReadLine().Split(' ');
                int w = int.Parse(wh[0]);
                int h = int.Parse(wh[1]);
                if (w == 0) return;
                string[] map = new string[h + 1];
                string[,] dp = new string[h + 1, w + 1];
                string ans = "";
                for (int i = 0; i < h + 1; i++)
                {
                    for (int j = 0; j < w + 1; j++)
                    {
                        dp[i, j] = "";
                    }
                }

                for (int i = 0; i <= w; i++)
                {
                    map[0] += "A";
                }
                for (int i = 1; i <= h; i++)
                {
                    map[i] = "A" + Console.ReadLine();
                }

                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <= w; j++)
                    {
                        if (map[i][j] - '0' < 10)
                        {
                            dp[i, j] = maxstr(dp[i - 1, j], dp[i, j - 1]) + map[i][j];
                        }
                        if (dp[i, j] == "0") dp[i, j] = "";
                        ans = maxstr(ans, dp[i, j]);
                    }
                }
                Console.WriteLine(ans);
            }
        }
        
        static string maxstr(string s1, string s2)
        {
            if (s1.Length > s2.Length) return s1;
            if (s2.Length > s1.Length) return s2;
            if (s1.CompareTo(s2) > 0) return s1;
            else return s2;
        }
    }
}
