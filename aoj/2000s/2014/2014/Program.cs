using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] wh = Console.ReadLine().Split(' ');
                int ylen = int.Parse(wh[0]);
                int xlen = int.Parse(wh[1]);
                if (ylen == 0 && xlen == 0)
                {
                    return;
                }
                string[] map = new string[xlen];
                for (int i = 0; i < xlen; i++)
                {
                    map[i] = Console.ReadLine();
                }
                bool[,] bcheck = new bool[xlen, ylen];
                bool[,] wcheck = new bool[xlen, ylen];
                int[] dx = { 1, -1, 0, 0 };
                int[] dy = { 0, 0, 1, -1 };
                Queue<int> qbx = new Queue<int>();
                Queue<int> qby = new Queue<int>();
                Queue<int> qwx = new Queue<int>();
                Queue<int> qwy = new Queue<int>();
                for (int x = 0; x < xlen; x++)
                {
                    for (int y = 0; y < ylen; y++)
                    {
                        string now = map[x][y].ToString();
                        if (now == "B")
                        {
                            qbx.Enqueue(x);
                            qby.Enqueue(y);
                        }
                        else if (now == "W")
                        {
                            qwx.Enqueue(x);
                            qwy.Enqueue(y);
                        }
                    }
                }

                while (qbx.Count > 0)
                {
                    int nowx = qbx.Dequeue();
                    int nowy = qby.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int nextx = nowx + dx[i];
                        int nexty = nowy + dy[i];
                        if (0 <= nextx && nextx < xlen &&
                            0 <= nexty && nexty < ylen &&
                            map[nextx][nexty].ToString() == "." &&
                            bcheck[nextx, nexty] == false)
                        {
                            bcheck[nextx, nexty] = true;
                            qbx.Enqueue(nextx);
                            qby.Enqueue(nexty);
                        }
                    }
                }
                while (qwx.Count > 0)
                {
                    int nowx = qwx.Dequeue();
                    int nowy = qwy.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int nextx = nowx + dx[i];
                        int nexty = nowy + dy[i];
                        if (0 <= nextx && nextx < xlen &&
                            0 <= nexty && nexty < ylen &&
                            map[nextx][nexty].ToString() == "." &&
                            wcheck[nextx, nexty] == false)
                        {
                            wcheck[nextx, nexty] = true;
                            qwx.Enqueue(nextx);
                            qwy.Enqueue(nexty);
                        }
                    }
                }

                int bcnt = 0;
                int wcnt = 0;
                for (int x = 0; x < xlen; x++)
                {
                    for (int y = 0; y < ylen; y++)
                    {
                        if (bcheck[x,y] == true && wcheck[x,y] == false)
                        {
                            bcnt += 1;
                        }
                        else if (wcheck[x, y] == true && bcheck[x, y] == false)
                        {
                            wcnt += 1;
                        }
                    }
                }
                Console.WriteLine("{0} {1}", bcnt, wcnt);
            }
        }
    }
}
