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
            int n = int.Parse(Console.ReadLine());
            string[] astr = Console.ReadLine().Split(' ');
            int[] a = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(astr[i]);
            }
            int cnt = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] == 1 || (a[i - 1] == 1 && a[i + 1] == 1))
                {
                    cnt += 1;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
