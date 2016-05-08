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
            int[] nq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = new int[nq[0]];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
            for (int i = 0; i < nq[1]; i++)
            {
                int[] lrt = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = lrt[0] - 1; j < lrt[1]; j++)
                {
                    a[j] = lrt[2];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
