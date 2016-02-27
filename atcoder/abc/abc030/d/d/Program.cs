using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] na = Console.ReadLine().Split(' ');
            int n = int.Parse(na[0]);
            int a = int.Parse(na[1]) - 1;
            int aori = a;
            string kstr = Console.ReadLine();
            string[] bstr = Console.ReadLine().Split(' ');
            int[] b = new int[n];
            int[] brec = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(bstr[i]) -1;
                brec[i] = -1;
            }
            if (kstr.Length < 7)
            {
                int k = int.Parse(kstr);
                for (int i = 0; i < k; i++)
                {
                    a = b[a];
                }
            }
            else
            {
                int c = -1;
                int t = -1;
                for (int i = 0; i < n + 1; i++)
                {
                    if (brec[a] < 0)
                    {
                        brec[a] = (int)i;
                    }
                    else
                    {
                        c = i - brec[a];
                        t = brec[a];
                        break;
                    }
                    a = b[a];
                }
                a = aori;
                int kmodc = 0;
                for (int i = 0; i < kstr.Length; i++)
                {
                    kmodc = (kmodc * 10 + kstr[i] - '0') % c;
                }
                while (kmodc <= t)
                {
                    kmodc += c;
                }
                for (int i = 0; i < kmodc; i++)
                {
                    a = b[a];
                }
            }
            Console.WriteLine(a + 1);
        }
    }
}
