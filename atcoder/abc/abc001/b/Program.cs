using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            if(m<100)
            {
                Console.WriteLine("00");
            }
            else if(m<=5000)
            {
                Console.WriteLine((m / 100).ToString("D2"));
            }
            else if(m<=30000)
            {
                Console.WriteLine(m / 1000 + 50);
            }
            else if(m<=70000)
            {
                Console.WriteLine((m / 1000 - 30) / 5 + 80);
            }
            else Console.WriteLine(89);
        }
    }
}
