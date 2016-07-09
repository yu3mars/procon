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
            int n = int.Parse(Console.ReadLine());
            int ss = n % 60;
            n /= 60;
            int mm = n % 60;
            n /= 60;
            int hh = n;
            Console.WriteLine("{0}:{1}:{2}",hh.ToString("D2"),mm.ToString("D2"), ss.ToString("D2"));
        }
    }
}
