using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1172
{
    class Program
    {
        static void Main(string[] args)
        {
            //prime judge
            int maxn = 250000;
            bool[] prime = new bool[maxn];
            int[] primenum = new int[maxn];
            int cnt = 0;
            prime[0] = false;
            prime[1] = false;
            for (int i = 2; i < maxn; i++)
            {
                prime[i] = true;
            }
            for (int i = 2; i <= (i * i); i++)
            {
                if (prime[i] == true)
                {
                    for (int j = i * i; j < maxn; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
            for (int i = 2; i < maxn; i++)
            {
                if (prime[i] == true)
                {
                    cnt += 1;
                }
                primenum[i] = cnt;
            }
            
            //chebyshef
            for (; ; )
            {
                int target = int.Parse(Console.ReadLine());
                if (target == 0)
                {
                    return;
                }
                else
                {
                    int ans = primenum[target * 2] - primenum[target];
                    Console.WriteLine(ans);
                }
            }
        }
    }
}
