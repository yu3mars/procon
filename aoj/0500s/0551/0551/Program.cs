using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0551
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int l = int.Parse(str[1]);
            int[] ice = new int[n + 2];
            int[] penalty = new int[n + 2];
            int time = 0;
            SortedList<int, int> icicle = new SortedList<int, int>();//len,place
            for (int i = 1; i <= n; i++)
            {
                int len = int.Parse(Console.ReadLine());
                icicle[len] = i;
                ice[i] = len;
            }
            for(int i = n-2;i>=0;i--)
            {
                int checking = icicle.Values[i];
                if (ice[checking - 1] < ice[checking])
                {
                    penalty[checking - 1] = Math.Max(penalty[checking - 1], l - ice[checking] + penalty[checking]);
                }
                if (ice[checking + 1] < ice[checking])
                {
                    penalty[checking + 1] = Math.Max(penalty[checking + 1], l - ice[checking] + penalty[checking]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                time = Math.Max(time, l - ice[i] + penalty[i]);
            }
            Console.WriteLine(time);
        }
    }
}
