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
            int[] nab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nab[0];
            double a = nab[1];
            double b = nab[2];
            double[] s = new double[n];
            double ave = 0;
            double min = double.MaxValue / 3;
            double max = -1;
            for (int i = 0; i < n; i++)
            {
                s[i] = double.Parse(Console.ReadLine());
                ave += s[i];
                min = Math.Min(min, s[i]);
                max = Math.Max(max, s[i]);
            }
            ave /= n;
            double diff = max - min;
            if(diff==0 && b!=0)
            {
                Console.WriteLine(-1);
                return;
            }
            double p = b / diff;
            double q = a - ave * p;
            Console.WriteLine("{0} {1}", p, q);
        }
    }
}
