using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1249
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] checkx = new int[] { 1, 0, 0, 1, 1, 0, 1, -1, 0, 1, -1, 1, 1 };
            int[] checky = new int[] { 0, 1, 0, 1, 0, 1, -1, 0, 1, 1, 1, -1, 1 };
            int[] checkz = new int[] { 0, 0, 1, 0, 1, 1, 0, 1, -1, 1, 1, 1, -1 };
            for (; ; )
            {
                bool end = false;
                string[] nmp = Console.ReadLine().Split(' ');
                int n = int.Parse(nmp[0]);
                int m = int.Parse(nmp[1]);
                int p = int.Parse(nmp[2]);
                if (n == 0 && m == 0 && p == 0) return;

                int[, ,] map = new int[n, n, n];
                for (int i = 1; i <= p; i++)
                {
                    string[] xy = Console.ReadLine().Split(' ');
                    if (end == true) continue;

                    int x = int.Parse(xy[0]) - 1;
                    int y = int.Parse(xy[1]) - 1;
                    int z = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (map[x, y, j] == 0)
                        {
                            z = j;
                            break;
                        }
                    }
                    map[x, y, z] = i % 2 + 1;

                    for (int j = 0; j < checkx.Length; j++)
                    {
                        int nextx = x;
                        int nexty = y;
                        int nextz = z;
                        int cnt = 1;

                        for (; ; )
                        {
                            nextx += checkx[j];
                            nexty += checky[j];
                            nextz += checkz[j];
                            if (0 <= nextx && nextx < n &&
                                0 <= nexty && nexty < n &&
                                0 <= nextz && nextz < n)
                            {
                                if (map[nextx, nexty, nextz] == map[x, y, z])
                                {
                                    cnt += 1;
                                }
                                else break;
                            }
                            else break;                                
                        }
                        nextx = x;
                        nexty = y;
                        nextz = z;
                        for (; ; )
                        {
                            nextx -= checkx[j];
                            nexty -= checky[j];
                            nextz -= checkz[j];
                            if (0 <= nextx && nextx < n &&
                                0 <= nexty && nexty < n &&
                                0 <= nextz && nextz < n)
                            {
                                if (map[nextx, nexty, nextz] == map[x, y, z])
                                {
                                    cnt += 1;
                                }
                                else break;
                            }
                            else break;
                        }
                        if (cnt >= m)
                        {
                            if (i % 2 == 1)
                            {
                                Console.WriteLine("Black {0}",i);
                            }
                            else
                            {
                                Console.WriteLine("White {0}", i);
                            }
                            end = true;
                            break;
                        }
                        if (end == true) break;
                    }
                }
                if (end == false) Console.WriteLine("Draw");
            }
        }
    }
}
