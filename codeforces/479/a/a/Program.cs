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
            int c = int.Parse(Console.ReadLine());
            int ans = 0;
            ans = Math.Max(ans, a + b + c);
            ans = Math.Max(ans, (a + b) * c);
            ans = Math.Max(ans, a + b * c);
            ans = Math.Max(ans, a * (b + c));
            ans = Math.Max(ans, a * b + c);
            ans = Math.Max(ans, a * b * c);
            Console.WriteLine(ans);
        }
    }
}
