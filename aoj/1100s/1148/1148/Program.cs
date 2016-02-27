using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1148
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                if (n == 0 && m == 0)
                {
                    return;
                }
                int[,] map = new int[10001, 1261];
                int r = int.Parse(Console.ReadLine());
                for (int i = 0; i < r; i++)
                {
                    string[] uses = Console.ReadLine().Split(' ');
                    int[] usei = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        usei[j] = int.Parse(uses[j]);
                    }
                    if (usei[3] == 0)
                    {
                        map[usei[2], usei[0]] -= 1;
                    }
                    else
                    {
                        map[usei[2], usei[0]] += 1;
                    }
                }
                for (int j = 0; j < 10001; j++)
                {
                    int now = 0;
                    for (int i = 540; i < 1261; i++)
                    {
                        now += map[j, i];
                        map[j, i] = now;
                    }
                }
                int q = int.Parse(Console.ReadLine());
                for (int k = 0; k < q; k++)
                {
                    string[] ques = Console.ReadLine().Split(' ');
                    int[] quei = new int[3];
                    for (int l = 0; l < 3; l++)
                    {
                        quei[l] = int.Parse(ques[l]);
                    }
                    int cnt = 0;
                    for (int i = quei[0]; i < quei[1]; i++)
                    {
                        if (map[quei[2], i] > 0)
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
