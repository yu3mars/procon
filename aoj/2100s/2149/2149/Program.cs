using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2149
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nabcx = Console.ReadLine().Split(' ');
                int n = int.Parse(nabcx[0]);
                int a = int.Parse(nabcx[1]);
                int b = int.Parse(nabcx[2]);
                int c = int.Parse(nabcx[3]);
                int x = int.Parse(nabcx[4]);
                if (n == 0 && a == 0 && b == 0 && c == 0 && x == 0)
                {
                    return;
                }
                string[] y = Console.ReadLine().Split(' ');
                int now = 0;
                bool done = false;
                int ans = 0;
                for (int i = 0; i <= 10000; i++)
                {
                    while (x == int.Parse(y[now]))
                    {
                        now += 1;
                        if (now == n)
                        {
                            done = true;
                            ans = i;
                        }
                        break;
                    }
                    if (done == true)
                    {
                        break;
                    }
                    x = (a * x + b) % c;
                }
                if (done == true)
                {
                    Console.WriteLine(ans);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
