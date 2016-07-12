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
            int t = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int m = int.Parse(Console.ReadLine());
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int acnt = 0;
            int bcnt = 0;
            while (bcnt < m)
            {
                if (acnt >= n)
                {
                    Console.WriteLine("no");
                    return;
                }

                if (a[acnt] <= b[bcnt] && b[bcnt] <= a[acnt] + t)
                {
                    bcnt++;
                }
                acnt++;
            }
            Console.WriteLine("yes");
        }
    }
    
}
