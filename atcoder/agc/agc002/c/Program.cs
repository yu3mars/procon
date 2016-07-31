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
            long[] nl = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = nl[0];
            long l = nl[1];
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long fin = -1;
            for (long i = 0; i < n - 1; i++)
            {
                if (a[i] + a[i + 1] >= l)
                {
                    fin = i + 1;
                    break;
                }
            }
            if (fin < 0)
            {
                Console.WriteLine("Impossible");
                return;
            }
            Console.WriteLine("Possible");

            for (long i = 1; i < fin; i++)
            {
                    Console.WriteLine(i);
            }
            for (long i = n - 1; i >= fin; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
