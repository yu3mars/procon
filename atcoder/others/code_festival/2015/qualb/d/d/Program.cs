using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        //static SortedList<long, long> ls;
        static long[] sbgn;
        static long[] send;

        static void Main(string[] args)
        {
            //long LEN = int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            //long[] sbgn = new long[n];
            //long[] send = new long[n];
            sbgn = new long[n];
            send = new long[n];

            long[] c = new long[n];
            long[] cnt = new long[n];
            //long[] ans = new long[n];
            //long[] jump = new long[LEN];
            //bool[] map = new bool[LEN];
            for (int i = 0; i < n; i++)
            {
                string[] sc = Console.ReadLine().Split(' ');
                sbgn[i] = long.Parse(sc[0]);
                c[i] = long.Parse(sc[1]);
                //send[i] = sbgn[i];
            }
            //SortedList<long, long> ls = new SortedList<long, long>();
            for (int i = 0; i < n; i++)
            {
                long snow = sbgn[i];
                while (cnt[i] < c[i])
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (sbgn[j] <= snow && snow <= send[j])
                        {
                            snow = send[j] + 1;
                            break;
                        }
                    }
                    long[] next = searchNext(i, snow, c[i] - cnt[i]);
                    if (next[0] == long.MaxValue)
                    {
                        snow += c[i] - cnt[i] - 1;
                        cnt[i] = c[i];
                        
                    }
                    else
                    {
                        cnt[i] += next[0] - snow;
                        snow = next[1];
                    }
                }
                send[i] = snow;
                //jump[sbgn[i]] = send[i];
                Console.WriteLine(snow);
                //ls.Add(i,sbgn[i]);
            }

        }

        static long[] searchNext(int nowi, long snow, long cleft)
        {
            long[] r = new long[2];
            r[0] = long.MaxValue;
            r[1] = long.MaxValue;
            for (int i = 0; i < nowi; i++)
            {
                if (snow < sbgn[i] && sbgn[i] <= snow+cleft)
                {
                    if (r[0] > sbgn[i])
                    {
                        r[0] = sbgn[i];
                        r[1] = send[i];
                    }                    
                }
            }
            return r;
        }
    }
}
