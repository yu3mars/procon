using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    class Program
    {
        static long[,] grid;
        static int[] vr = { 0, 0, 1, 1 };
        static int[] vc = { 0, 1, 0, 1 };
        static int r, c, n;
        static long empty = long.MinValue / 10;



        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            r = rc[0];
            c = rc[1];
            n = int.Parse(Console.ReadLine());
            grid = new long[r + 2, c + 2];
            for (int i = 0; i < r + 2; i++)
            {
                for (int j = 0; j < c + 2; j++)
                {
                    grid[i, j] = empty;
                }
            }
            Queue<long> qr = new Queue<long>();
            Queue<long> qc = new Queue<long>();

            for (int i = 0; i < n; i++)
            {
                int[] rca = Console.ReadLine().Split().Select(int.Parse).ToArray();
                grid[rca[0], rca[1]] = rca[2];
                qr.Enqueue(rca[0]);
                qc.Enqueue(rca[1]);
            }
            while (qr.Count > 0)
            {
                long nextr = qr.Dequeue();
                long nextc = qc.Dequeue();
                long tmpval = empty;

                for (int i = 0; i < 4; i++)
                {
                    long tmp = judge(nextr - vr[i], nextc - vc[i]);
                    if (tmp == empty) continue;
                    else if (tmp < 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                    else
                    {
                        if (tmpval == empty) tmpval = tmp;
                        else if (tmpval != tmp)
                        {
                            Console.WriteLine("No");
                            return;
                        }
                    }
                }
            }
            /*
            for (int rcnt = 1; rcnt <= r; rcnt++)
            {
                for (int ccnt = 1; ccnt <= c; ccnt++)
                {
                     if(grid[rcnt,ccnt]<0)
                    {
                        long tmpval = empty;
                        for (int i = 0; i < 4; i++)
                        {
                            long tmp = judge(rcnt - vr[i], ccnt - vc[i]);
                            if (tmp == empty) continue;
                            else if(tmp < 0)
                            {
                                Console.WriteLine("No");
                                return;
                            }
                            else
                            {
                                if (tmpval == empty) tmpval = tmp;
                                else if(tmpval != tmp)
                                {
                                    Console.WriteLine("No");
                                    return;
                                }
                            }
                        }
                    }
                }                
            }
            */
            Console.WriteLine("Yes");
        }
        static long judge(long rtmp,long ctmp)
        {
            int empcnt = 0;
            long[] sqval = new long[4];
            for (int i = 0; i < 4; i++)
            {
                sqval[i] = grid[rtmp + vr[i], ctmp + vc[i]];
                if (sqval[i] == empty) empcnt++;
                
            }
            if(empcnt==1)
            {
                if (sqval[0] == empty)
                {
                    return sqval[1] + sqval[2] - sqval[3];
                }
                else if (sqval[3] == empty)
                {
                    return sqval[1] + sqval[2] - sqval[0];
                }
                else if (sqval[1] == empty)
                {
                    return sqval[0] + sqval[3] - sqval[2];
                }
                else if (sqval[2] == empty)
                {
                    return sqval[0] + sqval[3] - sqval[1];
                }
                return -2;
            }
            else if(empcnt==0)
            {
                if (sqval[0] + sqval[3] == sqval[1] + sqval[2])
                {
                    return empty;
                }
                else return -1;
            }
            else return empty;
        }
    }
}
