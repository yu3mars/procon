using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0576
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int jp = a /c;
            int ma = b / d;

            if (a % c != 0)
            {
                jp += 1;
            }
            if (b % d != 0)
            {
                ma += 1;
            }
            int need = Math.Max(jp, ma);
            Console.WriteLine(l - need);
        }
    }
}
