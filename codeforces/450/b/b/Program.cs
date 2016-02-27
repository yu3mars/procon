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
            string[] str = Console.ReadLine().Split(' ');
            int target = int.Parse(Console.ReadLine()) % 6 + 6;
            int[] f = new int[target + 2];
            f[1] = int.Parse(str[0]);
            f[2] = int.Parse(str[1]);
            if (target >= 3)
            {
                for (int i = 3; i <= target; i++)
                {
                    f[i] = f[i - 1] - f[i - 2];
                }
            }
            int ans = f[target] % 1000000007;
            while (ans < 0)
            {
                ans += 1000000007;
            }
            Console.WriteLine(ans);
            return;
        }
    }
}
