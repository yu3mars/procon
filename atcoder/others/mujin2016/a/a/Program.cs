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
            string s = Console.ReadLine();
            if (s == "K" || s == "L" || s == "O" || s == "P")
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Left");
            }
        }
    }
}
