using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double ans = d[0] * d[0] * d[1] / 10000;
            Console.WriteLine(ans);
        }
    }
}
