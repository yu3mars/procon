using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] cnt = new int[4];
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'A') cnt[0] += 1;
                else if (s[i] == 'T') cnt[1] += 1;
                else if (s[i] == 'G') cnt[2] += 1;
                else if (s[i] == 'C') cnt[3] += 1;
            }
            long ans = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < cnt[i]; j++)
                {
                    ans  = ans * (n - j) / (j + 1) % 1000000007;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
