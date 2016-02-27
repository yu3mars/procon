using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTL_1_A
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
                    for (int j = i * 2; j< isprime.Length; j += i)
                    {
                        isprime[j] = false;
                    }
                }
            }

            int n = int.Parse(Console.ReadLine());
            int norigin = n;
            string ans = "";
            for (int i = 2; i * i <= norigin; i++)
            {
                while (isprime[i] == true && n % i == 0)
                {
                    ans = ans + " " + i.ToString();
                    n = n / i;
                }
            }
            if (n != 1)
            {
                ans =ans + " " + n.ToString();
            }
            Console.WriteLine("{0}:{1}", norigin, ans);
            Console.ReadLine();
        }
    }
}
