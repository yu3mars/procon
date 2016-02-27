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
            string[] rck = Console.ReadLine().Split(' ');
            int r = int.Parse(rck[0]);
            int c = int.Parse(rck[1]);
            int k = int.Parse(rck[2]);
            string[] map = new string[r];
            for (int i = 0; i < r; i++)
            {
                map[i] = Console.ReadLine();
            }
            int ans = 0;
            int[,] up = new int[r, c];
            int[,] down = new int[r, c];
            for (int j = 0; j < c; j++)
            {
                int cnt = 0;
                for (int i = 0; i < r; i++)
                {
                    if (map[i][j] != 'o')
                    {
                        cnt = 0;
                    }
                    else
                    {
                        cnt += 1;
                    }
                    up[i, j] = cnt;                    
                }
            }
            for (int j = 0; j < c; j++)
            {
                int cnt = 0;
                for (int i = r - 1; i >= 0; i--)
                {
                    if (map[i][j] != 'o')
                    {
                        cnt = 0;
                    }
                    else
                    {
                        cnt += 1;
                    }
                    down[i, j] = cnt;
                }
            }
            for (int i = k-1; i < r - k+1; i++)
            {
                for (int j = k-1; j < c - k+1; j++)
                {
                    if (up[i, j] >= k-1 && down[i, j] >= k-1)
                    {
                        bool flag = true;
                        for (int p = -k+1; p <= k-1; p++)
                        {
                            if (Math.Min(up[i, j + p], down[i, j + p])
                                < k - Math.Abs(p))
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            ans += 1;
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
