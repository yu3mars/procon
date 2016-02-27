using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int k = int.Parse(str[1]);
            int[] ans = new int[n];
            int kcnt = 0;
            bool nextisplus = true;
            ans[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (kcnt < k - 1)
                {
                    if (nextisplus == true)
                    {
                        ans[i] = ans[i - 1] + (n - kcnt - 1);
                        nextisplus = false;
                    }
                    else
                    {
                        ans[i] = ans[i - 1] - (n - kcnt - 1);
                        nextisplus = true;
                    }
                    kcnt += 1;
                }
                else
                {
                    if (nextisplus == true)
                    {
                        ans[i] = ans[i - 1] + 1;
                    }
                    else
                    {
                        ans[i] = ans[i - 1] - 1;
                    }
                }
            }
            Console.Write("1");
            for (int i = 1; i < n; i++)
            {
                Console.Write(" {0}",ans[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
