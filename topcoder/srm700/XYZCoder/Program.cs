using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XYZCoder_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
class XYZCoder
{
    public static int countWays(int room,int size)
    {
        long ans = 1;
        long mod = 1000000007;

        long[,] dp = new long[room * size + 10, room + 10]; //member,winner
        dp[0, 0] = 1;
        for (int member = 1; member <= room*size; member++)
        {
            for (int winner = 0; winner <= room; winner++)
            {
                if(winner>0 && member >= winner*size)
                {
                    dp[member, winner] = (dp[member - 1, winner] + dp[member - 1, winner - 1]) % mod;

                }
                else
                {
                    dp[member, winner] = dp[member - 1, winner];
                }
            }
        }
        ans = dp[room * size, room];
        for (int i = 1; i <= room; i++)
        {
            ans = (ans * i) % mod;
        }
        return (int)(ans % mod);
    }
}