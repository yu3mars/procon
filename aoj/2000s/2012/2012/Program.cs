using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2012
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int e = int.Parse(Console.ReadLine());
                if (e == 0)
                {
                    return;
                }
                int ans = int.MaxValue;
                for (int z = 0; z * z * z <= e; z++)
                {
                    int z3 = z * z * z;
                    for (int y = 0; y * y <= e - z3; y++)
                    {
                        int y2 = y * y;
                        int x = e - z3 - y2;
                        ans = Math.Min(ans, x + y + z);
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
