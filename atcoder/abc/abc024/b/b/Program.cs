using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nt = Console.ReadLine().Split(' ');
            int n = int.Parse(nt[0]);
            int t = int.Parse(nt[1]);
            int[] imos = new int[3000010];
            int[] imos2 = new int[3000010];
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                imos[a]++;
                imos[a + t]--;
            }
            for (int i = 0; i < 3000000; i++)
            {
                imos2[i + 1] = imos[i] + imos2[i];
            }
            for (int i = 0; i < 3000000; i++)
            {
                if (imos2[i] > 0) ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
