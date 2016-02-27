using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0515
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] loads = Console.ReadLine().Split(' ');
                int ns = int.Parse(loads[0]);
                int ew = int.Parse(loads[1]);
                if (ns == 0 && ew == 0)
                {
                    return;
                }
                int[,] dp = new int[ns+1, ew+1];

                int numban = int.Parse(Console.ReadLine());
                int[] nsban = new int[numban];
                int[] ewban = new int[numban];
                for (int i = 0; i < numban; i++)
                {
                    string[] bans = Console.ReadLine().Split(' ');
                    nsban[i] = int.Parse(bans[0]);
                    ewban[i] = int.Parse(bans[1]);
                }
                for (int i = 1; i <= ns; i++)
                {
                    for (int j = 1; j <= ew; j++)
                    {
                        bool banned = false;
                        for (int k = 0; k < nsban.Length; k++)
                        {
                            if (i == nsban[k] && j==ewban[k])
                            {
                                banned = true;                                    
                            }
                        }
                        if (i == 1 && j == 1)
                        {
                            dp[i, j] = 1;
                        }
                        else if (banned == true)
                        {
                            dp[i, j] = 0;
                        }
                        else
                        {
                            dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                        }
                        banned = false;
                    }                    
                }
                Console.WriteLine(dp[ns, ew]);
            }
        }
    }
}
