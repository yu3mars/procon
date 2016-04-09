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
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            Console.WriteLine((b - 1) / a + 1);
        }
    }
}
