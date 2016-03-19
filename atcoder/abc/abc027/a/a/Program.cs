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
            if (s[0] == s[1]) Console.WriteLine(s[2]);
            else if (s[0] == s[2]) Console.WriteLine(s[1]);
            else Console.WriteLine(s[0]);
        }
    }
}
