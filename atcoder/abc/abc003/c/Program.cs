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
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double ans = 0;
            Array.Sort(r);
            for (int i = nk[0] - nk[1]; i < nk[0]; i++)
            {
                ans = (ans + r[i]) / 2;
            }
            Console.WriteLine(ans);
        }
    }
}
