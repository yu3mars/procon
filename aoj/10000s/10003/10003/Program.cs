using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string[] str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);

            if (a < b)
            {
                Console.WriteLine("a < b");
            }
            else if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else 
            {
                Console.WriteLine("a == b");
            }
        }
    }
}
