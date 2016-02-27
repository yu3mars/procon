using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0567
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            int c = int.Parse(Console.ReadLine());
            int[] d = new int[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(d);
            Array.Reverse(d);

            int cal = c;
            int caldol = c / a;            
            for (int i = 0; i < n; i++)
            {
                int tmp = cal + d[i];
                int tmpdol = tmp / (a + b * (i + 1));
                if (tmpdol >= caldol)
                {
                    cal = tmp;
                    caldol = tmpdol;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(caldol);
        }
    }
}
