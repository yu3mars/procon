using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) % 2;
            if (n == 1) Console.WriteLine("Red");
            else Console.WriteLine("Blue");
        }
    }
}
