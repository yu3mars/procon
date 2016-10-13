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

        for (int rcnt = 0; rcnt < room; rcnt++)
        {
            ans = (ans * (rcnt * (size - 1) + 1)) % mod;
        }
        for (int i = 1; i <= room; i++)
        {
            ans = (ans * i) % mod;
        }
        return (int)(ans % mod);
    }
}