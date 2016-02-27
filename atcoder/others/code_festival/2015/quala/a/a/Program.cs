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
            int n = s.Length;
            s = s.Substring(0, n - 1) + "5";
            Console.WriteLine(s);
        }
    }
}
