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
            int n = int.Parse(Console.ReadLine());
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(t);
            switch (n)
            {
                case 1:
                    Console.WriteLine(t[0]);
                    break;
                case 2:
                    Console.WriteLine(t[1]);
                    break;
                case 3:
                    Console.WriteLine(Math.Max(t[0] + t[1], t[2]));
                    break;
                case 4:
                    Console.WriteLine(Math.Min(Math.Max(t[0] + t[1] + t[2], t[3]),
                        Math.Max(t[0] + t[3], t[1] + t[2])));
                    break;
                default:
                    break;
            }
        }
    }
}
