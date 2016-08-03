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
            int[] x = new int[n];
            int[] y = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
                x[i] = xy[0];
                y[i] = xy[1];
            }
            double ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    double len = Math.Pow(x[i] - x[j], 2) + Math.Pow(y[i] - y[j], 2);
                    ans = Math.Max(ans, len);
                }
            }
            Console.WriteLine(Math.Sqrt(ans));
        }
    }
}
