using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2242
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nq = Console.ReadLine().Split(' ');
                int n = int.Parse(nq[0]);
                int q = int.Parse(nq[1]);
                if (n == 0 && q == 0)
                {
                    return;
                }
                string[] nen = new string[n];
                int[] bgn = new int[n];
                int[] end = new int[n];
                for (int i = 0; i < n; i++)
                {
                    string[] nenstr = Console.ReadLine().Split(' ');
                    nen[i] = nenstr[0];
                    int diff = int.Parse(nenstr[1]);
                    end[i] = int.Parse(nenstr[2]);
                    bgn[i] = end[i] - diff;
                }
                for (int k = 0; k < q; k++)
                {
                    int tar = int.Parse(Console.ReadLine());
                    bool done = false;
                    for (int i = 0; i < n; i++)
                    {
                        if (bgn[i] < tar && tar <= end[i])
                        {
                            Console.WriteLine("{0} {1}", nen[i], tar - bgn[i]);
                            done = true;
                            break;
                        }
                    }
                    if (done == false)
                    {
                        Console.WriteLine("Unknown");
                    }
                }
            }
        }
    }
}
