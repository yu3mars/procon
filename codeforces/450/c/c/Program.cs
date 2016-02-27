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
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            int k = int.Parse(str[2]);
            int ans = 0;
            int tmpans;
            if (k > n + m - 2)
            {
                Console.WriteLine("-1");
                return;
            }
            //keisan hajime
            for (int i = 0; i < n; i++)
            {
                if (0 <= k - i && k - i < m)
                {
                    tmpans = (n / (i + 1)) * (m / (k - i + 1));
                    ans = Math.Max(ans, tmpans);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
