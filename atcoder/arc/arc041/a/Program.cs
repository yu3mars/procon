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
            int x = xy[0];
            int y = xy[1];
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y - Math.Abs(y - k));
        }
    }
}
