using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0023
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                double xa = double.Parse(str[0]);
                double ya = double.Parse(str[1]);
                double ra = double.Parse(str[2]);
                double xb = double.Parse(str[3]);
                double yb = double.Parse(str[4]);
                double rb = double.Parse(str[5]);

                double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));

                if (ra > d + rb)
                {
                    Console.WriteLine("2");
                }
                else if (rb > d + rb)
                {
                    Console.WriteLine("-2");
                }
                else if (ra + rb >= d)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
