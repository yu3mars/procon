using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] param = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double txa = param[0];
            double tya = param[1];
            double txb = param[2];
            double tyb = param[3];
            double t = param[4];
            double v = param[5];
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double[] xy = Console.ReadLine().Split().Select(double.Parse).ToArray();
                double kyori = Math.Sqrt(Math.Pow(txa - xy[0], 2) + Math.Pow(tya - xy[1], 2))
                    + Math.Sqrt(Math.Pow(txb - xy[0], 2) + Math.Pow(tyb - xy[1], 2));
                if(kyori<= t*v)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
