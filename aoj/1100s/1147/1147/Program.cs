using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1147
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                int max = int.MinValue;
                int min = int.MaxValue;
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    int s = int.Parse(Console.ReadLine());
                    sum += s;
                    max = Math.Max(max, s);
                    min = Math.Min(min, s);
                }
                int ans = (sum - max - min) / (n - 2);
                Console.WriteLine(ans);
            }
        }
    }
}
