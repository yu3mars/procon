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
            int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = Math.Min(abc[0], abc[1]);
            Console.WriteLine(abc[2]/a);
        }
    }
}
