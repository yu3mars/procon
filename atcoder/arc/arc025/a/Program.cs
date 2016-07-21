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
            int[] d = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] j = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            for (int i = 0; i < 7; i++)
            {
                ans += Math.Max(d[i], j[i]);
            }
            Console.WriteLine(ans);
        }
    }
}
