using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2330
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; true; i++)
            {
                if (n <= Math.Pow(3, i))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
