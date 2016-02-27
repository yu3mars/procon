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
            string[] nm = Console.ReadLine().Split(' ');
            double n = double.Parse(nm[0]);
            double m = double.Parse(nm[1]);
            double l = (360 * (n * 60 + m) / (12 * 60)) % 360;
            double s = 360 * m / 60 % 360;
            double ans = Math.Abs(s - l);
            ans = Math.Abs(Math.Min(ans, 360 - ans));
            Console.WriteLine(ans);
        }
    }
}
