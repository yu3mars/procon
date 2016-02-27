using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1276
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isprime = new bool[1300000];
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
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                int up = n;
                int down = n;
                for (; ; )
                {
                    if (isprime[up] == true)
                    {
                        break;
                    }
                    up += 1;
                }
                for (; ; )
                {
                    if (isprime[down] == true)
                    {
                        break;
                    }
                    down -= 1;
                }
                Console.WriteLine(up - down);
            }
        }
    }
}
