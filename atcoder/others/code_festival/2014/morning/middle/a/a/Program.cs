using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            string[] st = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int s = int.Parse(st[0]);
            int t = int.Parse(st[1]);

            int[,] road = new int[n, 3];
            int max = int.MaxValue;
            int minsumdis = max;
            int minsumtown = -1;
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    road[i, j] = int.Parse(str[j]);
                }
                road[i, 2] = int.Parse(str[2]);
            }

            for (int k = 0; k < n; k++)
            {
                int[] d = new int[n];
                bool[] check = new bool[n];
                for (int i = 0; i < n; i++)
                {
                    d[i] = max;
                }
                d[k] = 0;
                for (int i = 0; i < n; i++)
                {
                    int now = k;
                    int nowd = max;
                    for (int j = 0; j < n; j++)
                    {
                        if (nowd > d[j] && check[j] == false)
                        {
                            nowd = d[j];
                            now = j;
                        }
                    }
                    if (nowd == max)
                    {
                        break;
                    }
                    check[now] = true;
                    for (int j = 0; j < n; j++)
                    {
                        if (now == road[j, 0])
                        {
                            int next = road[j, 1];
                            int nextd = d[now] + road[j, 2];
                            if (nextd < d[next])
                            {
                                d[next] = nextd;
                            }
                        }
                        else if (now == road[j, 1])
                        {
                            int next = road[j, 0];
                            int nextd = d[now] + road[j, 2];
                            if (nextd < d[next])
                            {
                                d[next] = nextd;
                            }
                        }
                    }
                }
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += d[i];
                }
                if (sum < minsumdis)
                {
                    minsumdis = sum;
                    minsumtown = k;
                }
            }
            Console.WriteLine("{0} {1}", minsumtown, minsumdis);
        }

        static int dijkstra(int from, int to, int v,int[][] edge,int[][]dist)
        {
            int max = int.MaxValue;
            int[] d = new int[v];
            bool[] check = new bool[v];
            for (int i = 0; i < v; i++)
            {
                d[i] = max;
            }
            d[from] = 0;

            for (int i = 0; i < v; i++)
            {
                int now = 0;
                int nowd = max;
                for (int j = 0; j < v; j++)
                {
                    if (nowd > d[j] && !check[now])
                    {
                        nowd = d[j];
                        now = j;
                    }
                }
                if (nowd == max) break;
                check[now] = true;
                for (int j = 0; j < edge[now].Length; j++)
                {
                    int next = edge[now][j];
                    int nextd = d[now] + dist[now][j];
                    if (nextd < d[next])
                    {
                        d[next] = nextd;
                    }
                }
            }

            return d[0];
        }
    }
}
