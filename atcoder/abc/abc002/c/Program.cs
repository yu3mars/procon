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
            int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            xy[2] -= xy[0];
            xy[4] -= xy[0];
            xy[3] -= xy[1];
            xy[5] -= xy[1];
            Console.WriteLine(Math.Abs(xy[2] * xy[5] - xy[3] * xy[4]) / 2.0);
        }
    }
}
