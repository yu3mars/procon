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
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;
            long now = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if(a[i]<a[i+1])
                {
                    now++;
                }
                else
                {
                    ans += getMyC(now);
                    now = 1;
                }
            }
            ans += getMyC(now);
            Console.WriteLine(ans);

        }

        static long getMyC(long n)
        {
            return n * (n + 1) / 2;
        }

    }
}
