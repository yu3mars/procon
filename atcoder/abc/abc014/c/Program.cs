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
            int[] imos = new int[1000010];
            for (int i = 0; i < n; i++)
            {
                int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                imos[ab[0]]++;
                imos[ab[1] + 1]--;
            }
            int ans = 0;
            int tmp = 0;
            for (int i = 0; i < imos.Length; i++)
            {
                tmp += imos[i];
                ans = Math.Max(ans, tmp);
            }
            Console.WriteLine(ans);
        }
    }
}
