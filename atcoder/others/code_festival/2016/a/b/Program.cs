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
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                a[i]--;
            }
            for (int i = 0; i < n; i++)
            {
                if (a[a[i]] == i) ans++;
            }
            Console.WriteLine(ans/2);
        }
    }
}
