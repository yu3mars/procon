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
            string[] s = Console.ReadLine().Split(' ');
            double[] n = new double[4];
            for (int i = 0; i < 4; i++)
            {
                n[i] = double.Parse(s[i]);
            }
            double t = n[1] / n[0];
            double a = n[3] / n[2];
            if (t > a) Console.WriteLine("TAKAHASHI");
            else if (t < a) Console.WriteLine("AOKI");
            else Console.WriteLine("DRAW");
        }
    }
}
