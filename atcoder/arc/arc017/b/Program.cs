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
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int cnt = 1;
            int ans = 0;
            if (cnt >= k)
            {
                ans++;
            }
            for (int i = 1; i < n; i++)
            {
                if(a[i-1]<a[i])
                {
                    cnt++;
                }
                else
                {
                    cnt = 1;
                }
                if(cnt>=k)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
