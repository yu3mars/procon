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
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = Math.Abs(ab[0]);
            int b = Math.Abs(ab[1]);
            if (a < b) Console.WriteLine("Ant");
            else if (a > b) Console.WriteLine("Bug");
            else Console.WriteLine("Draw");
        }
    }
}
