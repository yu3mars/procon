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
            long n = long.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Deficient");
                return;
            }
            long sum = 1;
            for (long i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i + n / i;
                    if (i * i == n)
                    {
                        sum -= i;
                    }
                }
            }
            if (sum == n) Console.WriteLine("Perfect");
            else if (sum < n) Console.WriteLine("Deficient");
            else Console.WriteLine("Abundant");
        }
    }
}
