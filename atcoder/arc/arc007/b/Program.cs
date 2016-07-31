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
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            int[] cd = new int[n + 1];
            int[] cdk = new int[n + 1];
            for (int i = 0; i < cd.Length; i++)
            {
                cd[i] = i;
            }
            int now = 0;
            for (int i = 0; i < m; i++)
            {
                int next = int.Parse(Console.ReadLine());
                cd[now] = cd[next];
                cd[next] = 0;
                now = next;
            }
            for (int i = 0; i < cd.Length; i++)
            {
                cdk[cd[i]] = i;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(cdk[i]);
            }
        }
    }
}
