using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2197
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
                else
                {
                    int cnt = 0;
                    for (int i = 2; i <= num / 2 + num % 2; i++)
                    {
                        int bas = i*(i+1)/2;
                        if (num >= bas && (num - bas) % i == 0)
                        {
                            cnt += 1;
                        }
                    }
                    Console.WriteLine(cnt);
                }
            }
        }
    }
}
