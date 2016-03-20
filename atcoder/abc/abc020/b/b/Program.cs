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
            string[] s = Console.ReadLine().Split(' ');
            int a = 2 * (int.Parse(s[0] + s[1]));
            Console.WriteLine(a);
        }
    }
}
