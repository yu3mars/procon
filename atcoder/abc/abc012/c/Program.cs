using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2025 - int.Parse(Console.ReadLine());
            List<int> x = new List<int>();
            List<int> y = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                if (n % i == 0 && 0 < n / i && n / i < 10)
                {
                    x.Add(i);
                    y.Add(n / i);
                }
            }
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine("{0} x {1}", x[i], y[i]);
            }
        }
    }
}
