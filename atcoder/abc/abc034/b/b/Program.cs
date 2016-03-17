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
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine(n - 1);
            else Console.WriteLine(n + 1);
        }
    }
}
