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
            int num = int.Parse(Console.ReadLine());
            int ans = 0;
            int ans2 = 0;
            int max = 0;
            int tmp;
            ans = 0;
            int[] ls = new int[num];
            string[] str = Console.ReadLine().Split(' ');
            for (int k = 0; k < num; k++)
            {
                ls[k] = int.Parse(str[k]);
                if(ls[k] == num)
                {
                    max = k;
                }
            }
            int cnt = max;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < cnt; j++)
                {
                    if (ls[j] > ls[j + 1])
                    {
                        tmp = ls[j];
                        ls[j] = ls[j + 1];
                        ls[j + 1] = tmp;
                        ans += 1;
                    }
                }
                cnt -= 1;
            }
            cnt = max;
            for (int i = num-1; i > max ; i--)
            {
                for (int j = num-1; j > cnt; j--)
                {
                    if (ls[j] > ls[j - 1])
                    {
                        tmp = ls[j];
                        ls[j] = ls[j - 1];
                        ls[j - 1] = tmp;
                        ans2 += 1;
                    }
                }
                cnt += 1;
            }
            Console.WriteLine(ans + ans2);
        }

    }
}
