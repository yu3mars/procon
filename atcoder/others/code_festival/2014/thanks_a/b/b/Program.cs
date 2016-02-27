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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] ls = { a, b, c };
            Array.Sort(ls);
            Array.Reverse(ls);
            int cnt = 0;
            int total = 0;
            while (total < n)
            {
                total += ls[cnt % 3];
                cnt += 1;
            }
            Console.WriteLine(cnt);
        }
    }
}
