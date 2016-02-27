using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace f
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n + 2];
            int cnt = 0;
            int bcnt = 0;
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            b[n] = b[0];
            b[n + 1] = b[1];
            bool[] kouho = new bool[n + 2];
            bool[] bkouho = new bool[n + 2];

            int[] btrue = new int[n + 2];
            
            for (int i = 0; i < n; i++)
            {
                btrue[i + 1] = Lcm(b[i] , b[i + 1]);
            }
            btrue[0] = btrue[n];
            btrue[n + 1] = btrue[1];
            for (int i = 0; i < n; i++)
            {
                if (b[i + 1] != Lcm(btrue[i], btrue[i + 1]))
                {
                    kouho[i + 1] = true;
                    bkouho[i] = true;
                    bkouho[i + 2] = true;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (kouho[i] == true && kouho[i + 2] == true)
                {
                    kouho[i + 2] = false;
                }
                if (bkouho[i] == true && bkouho[i + 2] == true)
                {
                    bkouho[i + 2] = false;
                }
            }
            for (int i = 0; i < n + 1; i++)
            {
                if (kouho[i] == true)
                {
                    cnt += 1;
                }
                if (bkouho[i] == true)
                {
                    bcnt += 1;
                }
            }
            int ans = Math.Min(cnt, bcnt);
            Console.WriteLine(ans);
        }

        static int Lcm(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }

        static int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return (Gcd(b, a % b));
        }
    }
}
