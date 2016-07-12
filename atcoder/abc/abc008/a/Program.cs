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
            int[] st = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(st[1] - st[0] + 1);
        }
    }
}
