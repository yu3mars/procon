using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int testcase = 0; testcase < t; testcase++)
            {
                int[] nd = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = nd[0];
                int d = nd[1];

                int ans = 127 * (n - 1);
                if (n % 2 == 0)
                {
                    ans += 127 - d;
                    Console.WriteLine(ans);
                }
                else
                {
                    ans += d;
                    Console.WriteLine(ans);
                }
            }

        }
    }
}
