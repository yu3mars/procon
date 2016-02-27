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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int ans = Math.Abs(a) + Math.Abs(a - b) + Math.Abs(b);
            Console.WriteLine(ans);
        }
    }
}
