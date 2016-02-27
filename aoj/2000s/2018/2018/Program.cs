using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2018
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nmp = Console.ReadLine().Split(' ');
                int n = int.Parse(nmp[0]);
                int m = int.Parse(nmp[1]);
                int p = int.Parse(nmp[2]);
                if (n == 0 && m == 0 && p == 0)
                {
                    return;
                }
                int people = 0;
                int win = 0;
                for (int i = 1; i <= n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    people += num;
                    if (i == m)
                    {
                        win = num;
                    }
                }
                int ans = 0;
                if (p != 100 && win != 0)
                {
                    ans = people * (100 - p) / win;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
