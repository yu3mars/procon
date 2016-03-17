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
            string n = Console.ReadLine();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] != n[0])
                {
                    Console.WriteLine("DIFFERENT");
                    return;
                }
            }
            Console.WriteLine("SAME");
        }
    }
}
