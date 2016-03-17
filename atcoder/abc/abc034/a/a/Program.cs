using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            if (x < y) Console.WriteLine("Better");
            else Console.WriteLine("Worse");
        }
    }
}
