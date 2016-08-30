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
            int[] na = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = na[0];
            int a = na[1];
            int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long ans = 0;

            Array.Sort(x);
            for (int i = 0; i < n; i++)
            {
                x[i] -= a;
            }
            for (long i = 1; i < (1<<n); i++)
            {
                int tmp = 0;
                for (int j = 0; j < n; j++)
                {
                    if((1 << j & i) != 0)
                    {
                        tmp += x[j];

                    }
                }
                if(tmp==0)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
