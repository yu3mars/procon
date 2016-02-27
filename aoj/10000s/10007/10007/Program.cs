using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10007
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                x = int.Parse(str[0]);
                y = int.Parse(str[1]);
                if (x == 0 && y == 0)
                {
                    return;
                }
                else if (x <= y)
                {
                    Console.WriteLine("{0} {1}", x, y);
                }
                else
                {
                    Console.WriteLine("{0} {1}", y, x);
                }
            }
        }
    }
}
