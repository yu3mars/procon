using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0167
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt,ans,tmp;
            for (; ; )
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
                else
                {
                    cnt = num;
                    ans = 0;
                    int[] str = new int[num];
                    for (int k = 0; k < num; k++)
                    {
                        str[k] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < num-1; i++)
                    {
                        for (int j = 0; j < cnt-1; j++)
                        {
                            if (str[j] > str[j + 1])
                            {
                                tmp = str[j];
                                str[j] = str[j + 1];
                                str[j + 1] = tmp;
                                ans += 1;
                            }
                        }
                        cnt -= 1;
                    }
                    Console.WriteLine(ans);
                }
            }
        }
    }
}
