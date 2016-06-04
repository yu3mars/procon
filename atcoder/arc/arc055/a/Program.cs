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
            int n = int.Parse(Console.ReadLine());
            Console.Write("1");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("0");
            }
            Console.WriteLine("7");
        }
    }
}
