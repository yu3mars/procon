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
            int[] nab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nab[0];
            int a = nab[1];
            int b = nab[2];
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine());
                if (t < a || b <= t) ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
