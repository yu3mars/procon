using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10024
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            double[] n = new double[4];
            for (int i = 0; i < 4; i++)
            {
                n[i] = double.Parse(str[i]);
            }
            double ans = Math.Sqrt
                (Math.Pow(n[0] - n[2], 2) + Math.Pow(n[1] - n[3], 2));
            Console.WriteLine(ans);
        }
    }
}
