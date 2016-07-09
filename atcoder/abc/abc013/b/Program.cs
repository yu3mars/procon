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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int ans = Math.Min(Math.Abs(a - b), Math.Min(Math.Abs(b + 10 - a), Math.Abs(a + 10 - b)));
            Console.WriteLine(ans);

        }
    }
}
