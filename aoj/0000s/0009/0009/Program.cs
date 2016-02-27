using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0009
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isprime = new bool[1000005];
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
                    for (int j = i*2; j < isprime.Length; j += i)
                    {
                        isprime[j] = false;
                    }
                }
            }
            for (; ; )
            {
                string n = Console.ReadLine();
                if (n==null)
                {
                    return;
                }
                int cnt = 0;
                for (int i = 0; i <= int.Parse(n); i++)
                {
                    if (isprime[i] == true)
                    {
                        cnt += 1;
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
