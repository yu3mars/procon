using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            int[] ans = new int[3];
            for (int i = 0; i < c; i++)
            {
                int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Array.Sort(n);
                for (int j = 0; j < 3; j++)
                {
                    ans[j] = Math.Max(ans[j], n[j]);
                }
            }
            int vol = 1;
            for (int i = 0; i < 3; i++)
            {
                vol *= ans[i];
            }
            Console.WriteLine(vol);
        }
    }
}
