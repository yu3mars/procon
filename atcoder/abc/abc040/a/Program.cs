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
            int[] nx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Min(nx[1] - 1, nx[0] - nx[1]));
        }
    }
}
