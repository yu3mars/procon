using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2150
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isprime = new bool[500000];
            for (int i = 0; i < isprime.Length; i++)
            {
                isprime[i] = true;
            }
            isprime[0] = false;
            isprime[1] = false;
            for (int i = 2; i < isprime.Length; i++)
            {
                if (isprime[i] == true)
                {
                    for (int j = i * 2; j < isprime.Length; j += i)
                    {
                        isprime[j] = false;
                    }
                }
            }

            for (; ; )
            {
                string[] np = Console.ReadLine().Split(' ');
                int n = int.Parse(np[0]);
                int p = int.Parse(np[1]);
                if (n == -1 && p == -1)
                {
                    return;
                }
                int lslen = 70;
                int[] lsprime = new int[lslen];
                int cntlsprime = 0;
                int now = n;
                for (; ; )
                {
                    now += 1;
                    if (isprime[now] == true)
                    {
                        lsprime[cntlsprime] = now;
                        cntlsprime += 1;
                        if (cntlsprime == lslen)
                        {
                            break;
                        }
                    }
                }
                int[] addprime = new int[lslen * lslen];
                for (int i = 0; i < addprime.Length; i++)
                {
                    addprime[i] = int.MaxValue;
                }
                int cnt = 0;
                for (int i = 0; i < lslen; i++)
                {
                    for (int j = i; j < lslen; j++)
                    {
                        addprime[cnt] = lsprime[i] + lsprime[j];
                        cnt += 1;
                    }
                }
                Array.Sort(addprime);
                Console.WriteLine(addprime[p - 1]);
            }
        }
    }
}
