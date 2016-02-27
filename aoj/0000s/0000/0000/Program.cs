using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0000
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int ixj = i * j;
                    Console.WriteLine("{0}x{1}={2}", i, j, ixj);
                }
            }
        }
    }
}
