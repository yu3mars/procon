using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1241
{
    class Program
    {
        static int cnt, sum;
        static int[] ans;
        static void Main(string[] args)
        {
            ans=new int[1000000];
            cnt = 0;
            Loop(1);
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                Console.WriteLine(ans[n]);
            }
        }
        static void Loop(int before)
        {
            if (cnt < 4)
            {
                for (int i = before; i < 182; i++)
                {
                    int i2 = i * i;
                    cnt += 1;
                    sum += i2;
                    ans[sum] += 1;
                    Loop(i);
                    cnt -= 1;
                    sum -= i2;
                }
            }
        }
    }
}
