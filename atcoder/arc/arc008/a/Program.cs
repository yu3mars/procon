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
            int ans = n / 10 * 100;
            ans += Math.Min(100, (n % 10) * 15);
            Console.WriteLine(ans);
        }
    }
}
