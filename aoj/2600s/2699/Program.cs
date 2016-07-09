using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2699
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                int[] de = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (de[0] == 0) return;
                double ans = double.MaxValue / 3;
                for (int x = 0; x < de[0]; x++)
                {
                    int y = de[0] - x;
                    double money = Math.Abs(Math.Sqrt(x * x + y * y) - de[1]);
                    ans = Math.Min(ans, money);
                }
                Console.WriteLine(ans);
            }
        }
    }
}
