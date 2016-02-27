using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rc = Console.ReadLine().Split(' ');
            int mapr = int.Parse(rc[0]);
            int mapc = int.Parse(rc[1]);
            bool[,] map = new bool[mapr + 2, mapc + 2];
            bool[,] check = new bool[mapr + 2, mapc + 2];
            string[] start = Console.ReadLine().Split(' ');
            int startr = int.Parse(start[0]);
            int startc = int.Parse(start[1]);
            string[] goal = Console.ReadLine().Split(' ');
            int goalr = int.Parse(goal[0]);
            int goalc = int.Parse(goal[1]);            
            int n = int.Parse(Console.ReadLine());
            for (int k = 0; k < n; k++)
            {
                string[] sq = Console.ReadLine().Split(' ');
                int r = int.Parse(sq[0]);
                int c = int.Parse(sq[1]);
                int h = int.Parse(sq[2]);
                int w = int.Parse(sq[3]);
                for (int i = r; i < r + h; i++)
                {
                    for (int j = c; j < c + w; j++)
                    {
                        map[i, j] = true;
                    }
                }
            }
            if (map[startr, startc] == false)
            {
                Console.WriteLine("NO");
                return;
            }
            check[startr, startc] = true;
            Queue<int> qr = new Queue<int>();
            Queue<int> qc = new Queue<int>();
            int[] dr = {1,-1,0,0};
            int[] dc = {0,0,1,-1};
            qr.Enqueue(startr);
            qc.Enqueue(startc);
            
            while (qr.Count > 0)
            {
                int nowr = qr.Dequeue();
                int nowc = qc.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nextr = nowr + dr[i];
                    int nextc = nowc + dc[i];
                    if (map[nextr, nextc] == true && check[nextr, nextc] == false)
                    {
                        qr.Enqueue(nextr);
                        qc.Enqueue(nextc);
                        check[nextr, nextc] = true;
                    }
                }
            }
            if (check[goalr, goalc] == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
