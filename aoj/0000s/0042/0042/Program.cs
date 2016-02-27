using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0042
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 1;
            int maxweight, maxnum;
            for (; ; )
            {
                maxweight = int.Parse(Console.ReadLine());
                if (maxweight == 0)
                {
                    return;
                }
                maxnum = int.Parse(Console.ReadLine());
                
                int[,] dp =new int[maxnum+1,maxweight+1];
                int valuetotal = 0;
                int weighttotal = 0;
                for (int i = 0; i < maxnum; i++)
                {
                    
                    string[] str = Console.ReadLine().Split(',');
                    int value = int.Parse(str[0]);
                    int weight = int.Parse(str[1]);
                    for (int j = 0; j <= maxweight; j++) 
                    {
                        dp[i + 1, j] = Math.Max(dp[i, j], dp[i + 1, j]);
                        if (j + weight <= maxweight)
                        {
                            dp[i + 1, j + weight] =
                                Math.Max(dp[i + 1, j + weight], dp[i, j] + value);
                            if (dp[i + 1, j + weight] > valuetotal)
                            {
                                valuetotal = dp[i + 1, j + weight];
                                weighttotal = j + weight;
                            }
                            else if (dp[i + 1, j + weight] == valuetotal)
                            {
                                weighttotal = Math.Min(j + weight, weighttotal);
                            }
                        }
                    }                    
                }
                    
                Console.WriteLine("Case {0}:", cnt);
                cnt += 1;
                Console.WriteLine(valuetotal);
                Console.WriteLine(weighttotal);
            }
        }
    }
}
