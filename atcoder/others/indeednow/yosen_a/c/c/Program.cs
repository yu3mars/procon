using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ls = new int[n];
            for (int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());
                if (s == 0) s = -1;
                ls[i]=s;
            }
            Array.Sort(ls);            
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if ((n - k - 1) < 0) Console.WriteLine("0");
                else Console.WriteLine(ls[n - k - 1] + 1);
            }
        }
    }
}
