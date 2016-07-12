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
            int t = int.MaxValue / 3;
            for (int i = 0; i < n; i++)
            {
                t = Math.Min(t, int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(t);
        }
    }
}
