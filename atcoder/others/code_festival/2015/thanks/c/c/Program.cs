using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] hstr = Console.ReadLine().Split(' ');
            int x = int.Parse(Console.ReadLine());
            int[] h = new int[n];
            int ans = n + 1;
            for (int i = 0; i < n; i++)
            {
                h[i] = int.Parse(hstr[i]);
                if (x < h[i])
                {
                    ans = i + 1;
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
