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
            int k = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int ans = 0;
            if(n<k)
            {
                ans = n * x;
            }
            else
            {
                ans = k * x + (n - k) * y;
            }
            Console.WriteLine(ans);
        }
    }
}
