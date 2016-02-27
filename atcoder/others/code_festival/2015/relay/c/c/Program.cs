using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;

            if (n == 0) a = 32;
            else if (n == 1) a = 1;
            else if (n == 2) a = 6;
            else if (n == 3) a = 0;
            else if (n == 4) a = 2;
            else if (n == 5) a = 4;
            else if (n == 6) a = 7;
            else if (n == 7) a = 13;
            else if (n == 8) a = 11;
            else if (n == 9) a = 5;

            Console.WriteLine(a);
        }
    }
}
