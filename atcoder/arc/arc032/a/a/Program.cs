using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
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

            int n = int.Parse(Console.ReadLine());
            int sum = n * (n + 1) / 2;
            if (isprime[sum] == true)
            {
                Console.WriteLine("WANWAN");
            }
            else
            {
                Console.WriteLine("BOWWOW");
            }
        }
    }
}
