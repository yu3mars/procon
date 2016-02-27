using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2007
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = false;
            for (; ; )
            {
                int cost = int.Parse(Console.ReadLine());
                if (cost == 0)
                {
                    return;
                }
                string[] str = Console.ReadLine().Split(' ');
                int[] have = new int[4];
                int[] coin = { 10, 50, 100, 500 };
                int havetot = 0;
                for (int i = 0; i < 4; i++)
                {
                    have[i] = int.Parse(str[i]);
                    havetot += have[i] * coin[i];
                }
                int diff = havetot - cost;
                int[] given = new int[4];
                int[] ans = new int[4];
                for (int i = 3; i >= 0; i--)
                {
                    given[i] = diff / coin[i];
                    diff -= given[i] * coin[i];
                    ans[i] = have[i] - given[i];
                }
                if (start == true)
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 4; i++)
                {
                    if (ans[i] > 0)
                    {
                        Console.WriteLine("{0} {1}", coin[i], ans[i]);
                    }
                }
                start = true;
            }
        }
    }
}
