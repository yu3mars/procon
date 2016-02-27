using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0008
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string str = Console.ReadLine();
                if (str == null)
                {
                    return;
                }
                int n = int.Parse(str);
                int ans = 0;
                for (int a = 0; a < 10; a++)
                {
                    for (int b = 0; b < 10; b++)
                    {
                        for (int c = 0; c < 10; c++)
                        {
                            for (int d = 0; d < 10; d++)
                            {
                                if (a + b + c + d == n)
                                {
                                    ans += 1;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
