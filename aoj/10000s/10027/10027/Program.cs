using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10027
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int cmp = str[0].CompareTo(str[1]);
                if (cmp == 0)
                {
                    a += 1;
                    b += 1;
                }
                else if (cmp > 0)
                {
                    a += 3;
                }
                else
                {
                    b += 3;
                }
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
