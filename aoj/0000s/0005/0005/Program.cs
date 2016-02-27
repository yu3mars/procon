using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0005
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, tmp, amari, gcd;
            long lcm;
            while (true) 
            {
                try
                {
                    string[] str = Console.ReadLine().Split(' ');
                    a = int.Parse(str[0]);
                    b = int.Parse(str[1]);
                    if (a < b) //anytime a>=b ni suru
                    {
                        tmp = b;
                        b = a;
                        a = tmp;
                    }
                    amari = 1;
                    int tmpa = a;
                    int tmpb = b;
                    while (amari != 0)
                    {
                        amari = tmpa % tmpb;
                        tmpa = tmpb;
                        tmpb = amari;
                    }
                    gcd = tmpa;
                    lcm = (long)a * b / gcd;
                    Console.WriteLine("{0} {1}", gcd, lcm);
                }
                catch 
                {
                    return;               
                }
            }
        }
    }
}
