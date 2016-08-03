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
            int[] d = new int[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            int sum = d.Sum();
            int max = d.Max();
            Console.WriteLine(sum);
            if (sum >= max * 2) Console.WriteLine(0);
            else Console.WriteLine(max * 2 - sum);
        }
    }
}
