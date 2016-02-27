using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1187
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] mtprstr = Console.ReadLine().Split(' ');
                int m = int.Parse(mtprstr[0]);
                int t = int.Parse(mtprstr[1]);
                int p = int.Parse(mtprstr[2]);
                int r = int.Parse(mtprstr[3]);
                if (m == 0 && t == 0 && p == 0 && r == 0) return;
                int[,] time = new int[t + 1, p + 1];
                int[] score = new int[t + 1];
                for (int req = 0; req < r; req++)
                {
                    string[] substr = Console.ReadLine().Split(' ');
                    int[] subint = new int[4];
                    for (int i = 0; i < 4; i++)
                    {
                        subint[i] = int.Parse(substr[i]);
                    }
                    if (subint[3] == 0)
                    {
                        score[subint[1]] +=
                            (time[subint[1], subint[2]] + subint[0]) - 1000000;
                    }
                    else
                    {
                        time[subint[1], subint[2]] += 20;
                    }
                }
                SortedDictionary<int, string> dic = new SortedDictionary<int, string>();
                for (int i = 1; i <= t; i++)
                {
                    if (dic.ContainsKey(score[i]))
                    {
                        dic[score[i]] = i.ToString() + "=" + dic[score[i]];
                    }
                    else
                    {
                        dic.Add(score[i], i.ToString());
                    }
                }
                string[] vals = new string[dic.Values.Count];
                dic.Values.CopyTo(vals, 0);

                for (int i = 0; i < vals.Length; i++)
                {
                    Console.Write(vals[i]);
                    if (i < vals.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
