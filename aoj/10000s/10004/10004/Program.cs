using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, tmp;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);
            c = int.Parse(str[2]);
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if (b > c)
            {
                tmp = b;
                b = c;
                c = tmp;    
            }
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
