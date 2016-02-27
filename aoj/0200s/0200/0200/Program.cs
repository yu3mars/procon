using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0200
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] strnm = Console.ReadLine().Split(' ');
                int n = int.Parse(strnm[0]);
                int m = int.Parse(strnm[1]);
                if (n == 0 && m == 0)
                {
                    return;
                }
                int[,][] rail = new int[n, n][];
                int[,][] costtime = new int[n, n][];
                int max = int.MaxValue;
                
            }
        }
    }
}
