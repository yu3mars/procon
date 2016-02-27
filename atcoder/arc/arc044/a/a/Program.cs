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
            int n = int.Parse(Console.ReadLine());
            if(n == 2 || n == 3 || n == 5)
            {
                Console.WriteLine("Prime");
            }
            else if (n == 1 || n % 2 == 0 || n % 5 == 0 || n % 3 == 0)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");

            }
        }


    }
}
