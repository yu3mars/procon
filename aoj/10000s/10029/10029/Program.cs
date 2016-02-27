using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10029
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
            Array.Sort(a);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
                if (i != n - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
