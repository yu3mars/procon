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
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            Console.WriteLine(a[0] * a[1]);
        }
    }
}
