using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10008
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, d, r;
            double f;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);
            d = a / b;
            r = a % b;
            f = (double)a / b;
            string g = f.ToString("F6");
            Console.WriteLine("{0} {1} {2}", d, r, g);
        }
    }
}
