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
            int[] nq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] imos = new int[nq[0] + 1];
            int[] ls = new int[nq[0]];
            for (int i = 0; i < nq[1]; i++)
            {
                int[] lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                imos[lr[0] - 1]++;
                imos[lr[1]]--;
            }
            int tmp = 0;
            for (int i = 0; i < nq[0]; i++)
            {
                tmp += imos[i];
                ls[i] = tmp;
                if (ls[i] % 2 == 0) Console.Write("0");
                else Console.Write("1");
            }
            Console.WriteLine();
        }
    }
}
