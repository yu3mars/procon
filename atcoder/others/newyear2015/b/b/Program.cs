using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ls = new int[n];
            for (int i = 0; i < n; i++)
            {
                ls[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(ls);
            int ans = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (ls[i] > sum)
                {
                    sum += ls[i];
                    ans += 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
