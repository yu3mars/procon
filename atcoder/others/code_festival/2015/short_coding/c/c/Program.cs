using System;

namespace c
{
    class P
    {
        static void Main(string[] args)
        {
            Console.WriteLine(c(int.Parse(Console.ReadLine())));
        }
        static int c(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int i,j = 1;
                for (i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        j = Math.Max(j, c(n/i));
                    }
                }
                j += n / 100 + n / 10 % 10 + n % 10;
                return j;
            }
        }
    }
}