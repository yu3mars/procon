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
            int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(xy[1]/xy[0]);
        }
    }
}
