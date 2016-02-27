using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1232
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isprime = new bool[50000];
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

            List<int> primels = new List<int>();
            for (int i = 2; i < isprime.Length; i++)
            {
                if (isprime[i] == true)
                {
                    primels.Add(i);
                }
            }

            for (; ; )
            {
                string[] mab = Console.ReadLine().Split(' ');
                int m = int.Parse(mab[0]);
                int a = int.Parse(mab[1]);
                int b = int.Parse(mab[2]);
                if (m == 0 && a == 0 && b == 0) return;
                double aperb = (double)a / b;
                int max = int.MinValue;
                int ans1 = 0;
                int ans2 = 0;

                for (int i = 0; i < primels.Count; i++)
                {
                    for (int j = i; j < primels.Count; j++)
                    {
                        int pq = primels[i] * primels[j];
                        if (pq <= m)
                        {
                            double pperq = (double)primels[i] / primels[j];
                            if (aperb <= pperq)
                            {
                                if (max < pq)
                                {
                                    max = pq;
                                    ans1 = primels[i];
                                    ans2 = primels[j];
                                }
                            }
                            else break;
                        }
                        else break;
                    }
                }
                Console.WriteLine("{0} {1}", ans1, ans2);

            }

        }
    }
}
