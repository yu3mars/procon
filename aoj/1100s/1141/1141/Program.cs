using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1141
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isprime = new bool[1000000];
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
                string[] str = Console.ReadLine().Split(' ');
                int a = int.Parse(str[0]);
                int d = int.Parse(str[1]);
                int n = int.Parse(str[2]);
                if (a == 0 && d == 0 & n == 0)
                {
                    return;
                }
                int cnt = 0;

                for (; ; )
                {
                    if (isprime[a] == true)
                    {
                        cnt += 1;

                        if (cnt == n)
                        {
                            Console.WriteLine(a);
                            break;
                        }
                    }
                    a += d;
                }
            }
        }
    }
}
