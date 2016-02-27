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
            int[] a = new int[20];
            for (int i = 0; i < 2; i++)
            {
                a[i] = 100;                
            }
            a[2] = 200;
            for (int i = 3; i < 20; i++)
            {
                a[i] = a[i - 1] + a[i - 2] + a[i - 3];
            }
            Console.WriteLine(a[19]);
        }
    }
}
