using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SafeBetting.minRounds(1,2,1000));
        }
    }
}
class SafeBetting
{
    public static int minRounds(int a, int b, int c)//saitei,temochi,goal
    {
        int kake = b - a;
        int now = b;
        int ans = 0;
        while(now < c)
        {
            ans++;
            now += kake;
            kake = now - a;
        }
        return ans;
    }
}