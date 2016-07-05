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
            int[] wh = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (wh[0] * 3 == wh[1] * 4) Console.WriteLine("4:3");
            else Console.WriteLine("16:9");
        }
    }
}
