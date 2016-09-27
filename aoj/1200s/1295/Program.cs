using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1295
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int[] wd = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (wd[0] == 0) return;
                int[] win = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] din = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int[] wls = new int[21];
                int[] dls = new int[21];
                for (int i = 0; i < win.Length; i++)
                {
                    wls[win[i]]++;
                }
                for (int i = 0; i < din.Length; i++)
                {
                    dls[din[i]]++;
                }
                int ans = 0;
                for (int i = 0; i < wls.Length; i++)
                {
                    ans += i * Math.Max(wls[i], dls[i]);
                }
                Console.WriteLine(ans);
            }
        }
    }
}
