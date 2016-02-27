using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = int.Parse(Console.ReadLine());
            }
            int a = t[0]+t[1];
            bool ng = false;
            for (int i = 2; i < n; i++)
            {
                a += t[i];
                if (a < k)
                {
                    Console.WriteLine(i + 1);
                    ng = true;
                    return;
                }
                a -= t[i - 2];
            }
            if (ng == false) Console.WriteLine(-1);
        }
    }
}
