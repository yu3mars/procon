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
            int y = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if(m<3)
            {
                m += 12;
                y--;
            }
            int a = 365 * y + y / 4 - y / 100 + y / 400 + (306 * (m + 1)) / 10 + d - 429;
            Console.WriteLine(735369 - a);
        }
    }
}
