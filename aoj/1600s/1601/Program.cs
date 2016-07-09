using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1601
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                int[] w = new int[n];
                for (int i = 0; i < n; i++)
                {
                    w[i] = Console.ReadLine().Length;
                }
                for (int i = 0; i < n; i++)
                {
                    bool f5 = false;
                    bool f12 = false;
                    bool f17 = false;
                    bool f24 = false;
                    bool f31 = false;

                    int cnt = 0;
                    for (int j = i; j < n; j++)
                    {
                        cnt += w[j];
                        if (cnt == 5) f5 = true;
                        else if (cnt == 12) f12 = true;
                        else if (cnt == 17) f17 = true;
                        else if (cnt == 24) f24 = true;
                        else if (cnt == 31) f31 = true;

                        if (cnt >= 31) break;
                    }
                    if (f5 && f12 && f17 && f24 && f31)
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                }

            }
        }
    }
}
