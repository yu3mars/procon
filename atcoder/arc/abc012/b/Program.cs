using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nl = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nl[0];
            double va = nl[1];
            double vb = nl[2];
            double l = nl[3];
            for (int i = 0; i < n; i++)
            {
                l = l / va * vb;
            }
            Console.WriteLine(l.ToString("F10"));
        }
    }
}
