using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2508
{
    class Program
    {
        static void Main(string[] args)
        {
            string ls = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                string[] kstr = Console.ReadLine().Split(' ');
                int[] k = new int[n];
                for (int i = 0; i < n; i++)
                {
                    k[i] = int.Parse(kstr[i]);
                }
                string tar = Console.ReadLine();
                string ans = "";
                for (int i = 0; i < tar.Length; i++)
                {
                    int diff = k[i % k.Length];
                    int now = 0;
                    for (int j = 0; j < ls.Length; j++)
                    {
                        if (tar[i] == ls[j])
                        {
                            now = j;
                            break;
                        }
                    }
                    now = (now + 52 - diff) % 52;
                    ans += ls[now].ToString();
                }
                Console.WriteLine(ans);
            }
        }
    }
}
