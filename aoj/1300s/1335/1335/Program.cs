using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1335
{
    class Program
    {
        static int ans,n,k,s,cnt,sum;
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nks = Console.ReadLine().Split(' ');
                n = int.Parse(nks[0]);
                k = int.Parse(nks[1]);
                s = int.Parse(nks[2]);
                if (n == 0 && k == 0 && s == 0) return;
                ans = 0;
                cnt = 0;
                sum = 0;

                Loop(0);
                Console.WriteLine(ans);
            }
        }
        static void Loop(int before)
        {
            if (k == cnt)
            {
                if (sum == s) ans += 1;
            }
            else
            {
                for (int i = before+1; i <= n; i++)
                {
                    cnt += 1;
                    sum += i;
                    Loop(i);
                    cnt -= 1;
                    sum -= i;
                }
            }
        }
    }
}
