using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nl = Console.ReadLine().Split(' ');
            int n = int.Parse(nl[0]);
            int l = int.Parse(nl[0]);
            if (n > 2002 || l>2002) return;

            List<int>[] ls = new List<int>[l + 2];//time
            for (int i = 0; i < ls.Length; i++)
            {
                ls[i] = new List<int>();
            }
            for (int i = 0; i < n; i++)
            {
                string[] tp = Console.ReadLine().Split(' ');
                int t = int.Parse(tp[0]);
                int p = int.Parse(tp[0]);
                ls[t].Add(p);
            }
            int[,] table = new int[2002, 2002];//time,place
            int[,] dp = new int[2010, 2010];//time,place
            int[,] dp2 = new int[2010, 2010];//time,place
            for (int i = 0; i < 2005; i++)//time
            {
                for (int j = 0; j < 2005; j++)//place
                {
                    int score = 0;
                    for (int k = 0; k < ls[i].Count; k++)
                    {
                        score += Math.Abs(ls[i][k] - j);
                    }
                    table[i, j] = score;
                }
            }
            for (int i = 1; i < 2005; i++)//time
            {
                for (int j = 1; j < 2005; j++)//place
                {
                    dp[i, j] = Math.Min(table[i, j - 1], table[i, j]);
                }
            }
            for (int i = 1; i < 2005; i++)//time
            {
                for (int j = 0; j < 2005; j++)//place
                {
                    dp2[i, j] = table[i -1, j]+dp[i, j];
                }
            }
            Console.WriteLine(dp2[2002,2002]);
        }
    }
}
