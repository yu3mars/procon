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
            int[] nmab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nmab[0];
            int m = nmab[1];
            int a = nmab[2];
            int b = nmab[3];
            for (int i = 0; i < m; i++)
            {
                if(n<=a)
                {
                    n += b;
                }
                int c = int.Parse(Console.ReadLine());
                n -= c;
                if(n<0)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }
            Console.WriteLine("complete");
        }
    }
}
