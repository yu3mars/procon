using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double ans = 0;
            for (int i = 0; i < n; i++)
            {
                int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                ans += ab[0] * ab[1];
            }
            ans *= 1.05;
            Console.WriteLine((int)ans);
        }
    }
}
