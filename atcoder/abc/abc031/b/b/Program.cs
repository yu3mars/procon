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
            string[] lh = Console.ReadLine().Split(' ');
            int l = int.Parse(lh[0]);
            int h = int.Parse(lh[1]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < l)
                {
                    Console.WriteLine(l - a);
                }
                else if (h < a)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
