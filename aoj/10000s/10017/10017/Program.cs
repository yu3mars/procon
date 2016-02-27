using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10017
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int n = int.Parse(str[0]);
                int x = int.Parse(str[1]);
                int cnt = 0;
                if (n == 0 && x == 0)
                {
                    return;
                }
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        for (int k = j + 1; k <= n; k++)
                        {
                            if (i + j + k == x)
                            {
                                cnt += 1;
                            }
                        }
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
