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
            int a = nab[1];
            int b = nab[2];
            if (n < 6)
            {
                Console.WriteLine(b * n);
            }
            else
            {
                Console.WriteLine(a * (n - 5) + b * 5);
            }
        }
    }
}
