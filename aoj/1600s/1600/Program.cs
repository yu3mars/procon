using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1600
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int[] mnn = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (mnn[0] == 0) return;
                int[] p = new int[mnn[0]];
                for (int i = 0; i < mnn[0]; i++)
                {
                    p[i] = int.Parse(Console.ReadLine());
                }
                int ans = 0;
                int gap = 0;
                for (int i = mnn[1]; i <= mnn[2]; i++)
                {
                    if(gap <= p[i - 1]-p[i])
                    {
                        gap = p[i - 1] - p[i];
                        ans = i;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
