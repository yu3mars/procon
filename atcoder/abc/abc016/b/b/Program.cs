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
            string[] str = Console.ReadLine().Split(' ');
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);
            if (a + b == c && a - b == c)
            {
                Console.WriteLine("?");
            }
            else if (a + b == c)
            {
                Console.WriteLine("+");
            }
            else if (a - b == c)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("!");
            }
        }
    }
}
