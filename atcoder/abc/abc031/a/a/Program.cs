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
            string[] ad = Console.ReadLine().Split(' ');
            int a = int.Parse(ad[0]);
            int d = int.Parse(ad[1]);
            int ans = Math.Max((a + 1) * d, a * (d + 1));
            Console.WriteLine(ans);
        }
    }
}
