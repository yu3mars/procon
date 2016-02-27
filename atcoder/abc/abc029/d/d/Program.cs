using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long ans = 0;
            for (long l = 1; l <= n; l *= 10)
            {
                long num = (n / l) % 10;
                ans += n / (l * 10)*l;
                if (num == 1)
                {
                    ans += n % l + 1;
                }
                else if (num > 1)
                {
                    ans += l;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
