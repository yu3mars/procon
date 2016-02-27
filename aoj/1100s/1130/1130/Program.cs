using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1130
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int sizex = int.Parse(str[0]);
                int sizey = int.Parse(str[1]);
                if (sizex == 0 && sizey == 0)
                {
                    return;
                }
                char[][] map = new char[sizey][];
                bool[,] check = new bool[sizex,sizey];
                for (int i = 0; i < sizey; i++)
                {
                    map[i] = Console.ReadLine().ToCharArray();
                }
                Queue<int> qx = new Queue<int>();
                Queue<int> qy = new Queue<int>();
                for (int y = 0; y < sizey; y++)
                {
                    for (int x = 0; x < sizex; x++)
                    {
                        if (map[y][x].ToString() == "@")
                        {
                            qx.Enqueue(x);
                            qy.Enqueue(y);
                            check[x, y] = true;
                            break;
                        }
                    }
                }
                int[] vx = new int[4] { 1, -1, 0, 0 };
                int[] vy = new int[4] { 0, 0, 1, -1 };
                int ans = 1;
                while (qx.Count > 0)
                {
                    int x = qx.Dequeue();
                    int y = qy.Dequeue();
                    for (int k = 0; k < 4; k++)
                    {
                        int nextx = x + vx[k];
                        int nexty = y + vy[k];
                        if (nextx >= 0 && nextx < sizex &&
                            nexty >= 0 && nexty < sizey &&
                            check[nextx, nexty] == false &&
                            map[nexty][nextx].ToString() == ".")
                        {
                            qx.Enqueue(nextx);
                            qy.Enqueue(nexty);
                            check[nextx, nexty] = true;
                            ans += 1;
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
