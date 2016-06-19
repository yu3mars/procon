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
            int ans = int.MaxValue;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                int syou = n / i;
                int amari = n - i * syou;
                ans = Math.Min(ans, syou - i + amari);
            }

            Console.WriteLine(ans);
        }
    }
}
