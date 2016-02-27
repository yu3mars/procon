using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(str[i]);
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s = s * 2 + a[i];
            }
            Console.WriteLine(s);

        }
    }
}
