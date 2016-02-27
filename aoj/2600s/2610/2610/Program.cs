using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2610
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            if (n == 0 || n == 2)
            {
                a = 1;
            }
            else if (n == 1)
            {
                a = 2;
            }
            Console.WriteLine(a);
        }
    }
}
