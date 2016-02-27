using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10025
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            double a = double.Parse(str[0]);
            double b = double.Parse(str[1]);
            double c = double.Parse(str[2]);
            double h = b * Math.Sin(c / 180 * Math.PI);
            double s = a * h / 2;
            double l = a + b + Math.Sqrt(a * a + b * b
                - 2 * a * b * Math.Cos(c / 180 * Math.PI));
            Console.WriteLine(s);
            Console.WriteLine(l);
            Console.WriteLine(h);
        }
    }
}
