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
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (str1.Length > str2.Length)
            {
                Console.WriteLine(str1);
            }
            else
            {
                Console.WriteLine(str2);
            }
        }
    }
}
