using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2253
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] tn = Console.ReadLine().Split(' ');
                int t = int.Parse(tn[0]);
                int n = int.Parse(tn[1]);
                if (t == 0 && n == 0)
                {
                    return;
                }
                int[,] map = new int[201, 201];
                bool[,] ban = new bool[201, 201];
                for (int i = 0; i < 201; i++)
                {
                    for (int j = 0; j < 201; j++)
                    {
                        map[i, j] = -1;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    string[] banxy = Console.ReadLine().Split(' ');
                    int banx = int.Parse(banxy[0]) + 100;
                    int bany = int.Parse(banxy[1]) + 100;
                    ban[banx, bany] = true;
                }

                int[] dx = { -1, -1, 0, 0, 1, 1 };
                int[] dy = { -1, 0, -1, 1, 0, 1 };
                Queue<int> qx = new Queue<int>();
                Queue<int> qy = new Queue<int>();
                string[] start = Console.ReadLine().Split(' ');
                int startx = int.Parse(start[0]) + 100;
                int starty = int.Parse(start[1]) + 100;
                qx.Enqueue(startx);
                qy.Enqueue(starty);
                int cnt = 1;
                map[startx, starty] = 0;

                while (qx.Count > 0)
                {
                    int nowx = qx.Dequeue();
                    int nowy = qy.Dequeue();
                    for (int i = 0; i < 6; i++)
                    {
                        int nextx = nowx + dx[i];
                        int nexty = nowy + dy[i];
                        if (0 <= nextx && nextx < 201 &&
                            0 <= nexty && nexty < 201 &&
                            map[nextx, nexty] == -1 &&
                            ban[nextx, nexty] == false &&
                            map[nowx, nowy] < t)
                        {
                            qx.Enqueue(nextx);
                            qy.Enqueue(nexty);
                            map[nextx, nexty] = map[nowx, nowy] + 1;
                            cnt += 1;
                        }
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
