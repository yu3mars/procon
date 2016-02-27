using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2104
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int tcnt = 0; tcnt < t; tcnt++)
            {
                string[] nk = Console.ReadLine().Split(' ');
                int n = int.Parse(nk[0]);
                int k = int.Parse(nk[1]);
                string[] housestr = Console.ReadLine().Split(' ');
                if (n <= k)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int[] house = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        house[i] = int.Parse(housestr[i]);
                    }
                    int[] diff = new int[n - 1];
                    for (int i = 0; i < n - 1; i++)
                    {
                        diff[i] = house[i + 1] - house[i];
                    }
                    Array.Sort(diff);
                    Array.Reverse(diff);
                    int ans = house[n - 1] - house[0];
                    for (int i = 0; i < k - 1; i++)
                    {
                        ans -= diff[i];
                    }
                    Console.WriteLine(ans);
                }
            }
        }
    }
}
