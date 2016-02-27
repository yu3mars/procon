using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10001
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = int.Parse(Console.ReadLine());
            b = Math.Pow(a,3);
            Console.WriteLine((int)b);
        }
    }
}
