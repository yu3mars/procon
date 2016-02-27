using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10006
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, a;
            while (true)
            {
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Case {0}: {1}", i, a);
                    i += 1;
                }
            }
        }
    }
}
