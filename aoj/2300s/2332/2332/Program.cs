using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2332
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            int[] map = new int[n];
            int[] dp = new int[n];
            int[] dest = new int[n];
            bool[] loop = new bool[n];
            for (int i = 0; i < n; i++)
            {
                map[i] = int.Parse(Console.ReadLine());
                dp[i] = int.MaxValue;
                dest[i] = -1;
            }
            dp[0] = 0;
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            while(dp[n - 1] == int.MaxValue)//turn
            {
                //for (int i = 0; i < n; i++)//start
                int i = q.Dequeue();
                {
                    //if (dp[i] != int.MaxValue)
                    {
                        for (int j = 1; j <= 6; j++)//saikoro
                        {
                            int next = num(i + j);
                            if (loop[next] || dp[i] >= dp[next]) continue;
                            HashSet<int> set = new HashSet<int>();
                            bool loopflag = false;
                            while (map[next] != 0)
                            {
                                if (loop[next] || set.Contains(next))
                                {
                                    loopflag = true;
                                    break;
                                }
                                else if (dest[next] == -1)
                                {
                                    set.Add(next);
                                    next = num(next + map[next]);
                                    if (dp[i] >= dp[next]) break;
                                }
                                else
                                {
                                    next = dest[next];
                                    break;
                                }
                            }
                            set.Add(num(i + j));
                            if (loopflag)
                            {
                                foreach (int x in set)
                                {
                                    loop[x] = true;
                                    dest[x] = -2;
                                }
                            }
                            else
                            {
                                foreach (int x in set)
                                {
                                    dest[x] = next;
                                }
                                if (dp[next] > dp[i] + 1)
                                {
                                    dp[next] = dp[i] + 1;
                                    q.Enqueue(next);
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine(dp[n - 1]);
        }

        static int num(int i)
        {
            if (i >= n) return n - 1;
            return i;
        }
    }
}
