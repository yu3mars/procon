using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0207
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] wh = Console.ReadLine().Split(' ');
                int w = int.Parse(wh[0]);
                int h = int.Parse(wh[1]);
                if (w == 0) return;
                string[] xys = Console.ReadLine().Split(' ');
                int xs = int.Parse(xys[0]);
                int ys = int.Parse(xys[1]);
                string[] xyg = Console.ReadLine().Split(' ');
                int xg = int.Parse(xyg[0]);
                int yg = int.Parse(xyg[1]);
                int n = int.Parse(Console.ReadLine());
                int[,] map = new int[w + 2, h + 2];
                bool[,] check = new bool[w + 2, h + 2];
                int[] dx = { 1, -1, 0, 0 };
                int[] dy = { 0, 0, 1, -1 };

                for (int i = 0; i < n; i++)
                {
                    string[] strcdxy = Console.ReadLine().Split(' ');
                    int[] cdxy = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        cdxy[j] = int.Parse(strcdxy[j]);
                    }
                    int nurix = 2;
                    int nuriy = 2;
                    if (cdxy[1] == 0)
                    {
                        nurix = 4;
                    }
                    else
                    {
                        nuriy = 4;
                    }
                    for (int j = 0; j < nurix; j++)
                    {
                        for (int k = 0; k < nuriy; k++)
                        {
                            map[cdxy[2] + j, cdxy[3] + k] = cdxy[0];
                        }
                    }
                }
                int color = map[xs, ys];
                if (map[xg, yg] == 0 || color == 0)
                {
                    Console.WriteLine("NG");
                    continue;
                }                
                Queue<int> qx = new Queue<int>();
                Queue<int> qy = new Queue<int>();
                qx.Enqueue(xs);
                qy.Enqueue(ys);
                check[1, 1] = true;
                while (qx.Count > 0)
                {
                    int nowx = qx.Dequeue();
                    int nowy = qy.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int nextx = nowx + dx[i];
                        int nexty = nowy + dy[i];

                        if (map[nextx, nexty] == color
                            && check[nextx, nexty] == false)
                        {
                            qx.Enqueue(nextx);
                            qy.Enqueue(nexty);
                            check[nextx, nexty] = true;
                        }
                    }
                }
                if (check[xg, yg] == true)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("NG");
                }
            }
        }
    }
}
