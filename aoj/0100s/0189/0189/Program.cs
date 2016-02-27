using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0189
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                int[,] road = new int[n,3];
                int towns = 0;
                int max = int.MaxValue;
                int minsumdis = max;
                int minsumtown = -1;
                for (int i = 0; i < n; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    for (int j = 0; j < 2; j++)
                    {
                        road[i,j] = int.Parse(str[j]);
                        towns = Math.Max(towns, road[i,j]);
                    }
                    road[i,2] = int.Parse(str[2]);
                }
                towns += 1;

                for (int k = 0; k < towns; k++)
                {
                    int[] d = new int[towns];
                    bool[] check = new bool[towns];
                    for (int i = 0; i < towns; i++)
                    {
                        d[i] = max;
                    }
                    d[k] = 0;
                    for (int i = 0; i < towns; i++)
                    {
                        int now = k;
                        int nowd = max;
                        for (int j = 0; j < towns; j++)
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
                            if (now == road[j,0])
                            {
                                int next = road[j,1];
                                int nextd = d[now] + road[j, 2];
                                if (nextd < d[next])
                                {
                                    d[next] = nextd;
                                }
                            }
                            else if (now == road[j,1])
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
                    for (int i = 0; i < towns; i++)
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
        }
    }
}
