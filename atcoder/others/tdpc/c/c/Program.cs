using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static int[] r;

        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int man = (int)Math.Pow(2, k);
            r = new int[man];
            for (int i = 0; i < man; i++)
            {
                r[i] = int.Parse(Console.ReadLine());
            }
            double[,] dp = new double[k + 1, man];
            for (int i = 0; i < man; i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 1; i < k+1; i++)
            {
                for (int j = 0; j < man; j++)
                {
                    int beg = getBeg(i, j);
                    int end = beg + (int)Math.Pow(2, i - 1);
                    for (int l = beg; l < end; l++)
                    {
                        dp[i, j] += dp[i - 1, j] * dp[i - 1, l] * Prob(j, l);
                    }                    
                }
            }

            for (int i = 0; i < man; i++)
            {
                double ans = dp[k, i];
                Console.WriteLine(ans.ToString("F10"));
            }
        }

        static double Prob(int p, int q)
        {
            return 1 / (1 + Math.Pow(10, (double)(r[q] - r[p]) / 400));
        }

        static bool isRight(int n, int p)
        {
            if (p % (int)Math.Pow(2, n) < (int)Math.Pow(2, n - 1)) return true;
            else return false;
        }

        static int getBeg(int n, int p)
        {
            int ans = (p / (int)Math.Pow(2, n)) * (int)Math.Pow(2, n);
            if (isRight(n, p) == true) ans += (int)Math.Pow(2, n - 1);
            return ans;
        }
        /*
        static int getEnd(int n, int p)
        {
            int ans = (p / (int)Math.Pow(2, n) + 1) * (int)Math.Pow(2, n);
            if (isRight(n, p) == false) ans -= n;
            return ans;
        }
         */
    }
}
