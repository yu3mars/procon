using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dx = new int[4] { 0, 0, 1, -1 };
            int[] dy = new int[4] { 1, -1, 0, 0 };

            string[] rc = Console.ReadLine().Split(' ');
            int r = int.Parse(rc[0]);
            int c = int.Parse(rc[1]);

            string[] s = Console.ReadLine().Split(' ');
            int sx = int.Parse(s[0]) - 1;
            int sy = int.Parse(s[1]) - 1;
            string[] g = Console.ReadLine().Split(' ');
            int gx = int.Parse(g[0]) - 1;
            int gy = int.Parse(g[1]) - 1;

            string[] map = new string[r];
            for (int i = 0; i < r; i++)
            {
                map[i] = Console.ReadLine();
            }
            int[,] bfs = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    bfs[i, j] = -1;
                }
            }
            bfs[sx, sy] = 0;
            Queue<int> qx = new Queue<int>();  
            Queue<int> qy = new Queue<int>();
            qx.Enqueue(sx);
            qy.Enqueue(sy);
            while(qx.Count>0)
            {
                int nowx = qx.Dequeue();
                int nowy = qy.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nextx = nowx + dx[i];
                    int nexty = nowy + dy[i];
                    if (map[nextx][nexty] != '#' && bfs[nextx, nexty] < 0)
                    {
                        bfs[nextx, nexty] = bfs[nowx, nowy] + 1;
                        qx.Enqueue(nextx);
                        qy.Enqueue(nexty);
                    }
                }
            }
            Console.WriteLine(bfs[gx, gy]);
        }
    }
}
