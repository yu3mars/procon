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
            int[] p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(p);
            if (p[0] == 5 && p[1] == 5 && p[2] == 7) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
