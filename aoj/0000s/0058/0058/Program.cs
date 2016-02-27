using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0058
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int sizey = int.Parse(str[0]);
            int sizex = int.Parse(str[1]);
            int n = int.Parse(str[2]);

            char[][] map = new char[sizey][];
            int[,] count = new int[sizex, sizey];
            for (int i = 0; i < sizey; i++)
            {
                map[i] = Console.ReadLine().ToCharArray();
            }
            Queue<int> qx = new Queue<int>();
            Queue<int> qy = new Queue<int>();
            int ans = 0;
            for (int x = 0; x < sizex; x++)
            {
                for (int y = 0; y < sizey; y++)
                {
                    if (map[y][x].ToString() == "S")
                    {
                        qx.Enqueue(x);
                        qy.Enqueue(y);
                    }
                    else
                    {
                        count[x, y] = -1;
                    }
                }
            }
            int[] vx = new int[4] { 1, -1, 0, 0 };
            int[] vy = new int[4] { 0, 0, 1, -1 };
            int factory = 1;

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
                        count[nextx, nexty] == -1)
                    {

                        if (map[nexty][nextx].ToString() == factory.ToString())
                        {
                            ans =ans + count[x, y] + 1;
                            if (factory == n)
                            {
                                Console.WriteLine(ans);
                                return;
                            }
                            else
                            {
                                factory += 1;
                            }
                            qx.Clear();
                            qy.Clear();
                            qx.Enqueue(nextx);
                            qy.Enqueue(nexty);
                            for (int loopx = 0; loopx < sizex; loopx++)
                            {
                                for (int loopy = 0; loopy < sizey; loopy++)
                                {
                                    //if (count[loopx, loopy] != -2)
                                    //{
                                        count[loopx, loopy] = -1;
                                    //}
                                }
                            }
                            count[nextx, nexty] = 0;
                            break;
                        }
                        else if (map[nexty][nextx].ToString() == "X")
                        {
                            count[nextx, nexty] = -2;
                        }
                        else
                        {
                            count[nextx, nexty] = count[x, y] + 1;
                            qx.Enqueue(nextx);
                            qy.Enqueue(nexty);
                        }

                    }
                }
            }
        }
    }
}
