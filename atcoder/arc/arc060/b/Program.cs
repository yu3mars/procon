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
            long n = int.Parse(Console.ReadLine());
            long s = int.Parse(Console.ReadLine());

            if(s == 1)
            {
                Console.WriteLine(n);
                return;
            }
            for (int i = 2; i < 100000; i++)
            {
                if( func(i,n)==s)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
        
        static long func(long b,long n)
        {
            if (n < b) return n;
            else return func(b, n / b) + (n % b); 
        }
    }
}
