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
            int[] l = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(l);
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += l[i * 2];
            }
            Console.WriteLine(ans);
        }
    }
}
