using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            if (a > b || n <= a)
            {
                Console.WriteLine("Takahashi");
            }
            else if (a < b)
            {
                Console.WriteLine("Aoki");
            }
            else
            {
                if (n % (a + 1) != 0) Console.WriteLine("Takahashi");
                else Console.WriteLine("Aoki");
            }
        }
    }
}
