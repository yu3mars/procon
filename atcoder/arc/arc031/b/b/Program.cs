using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] map = new string[10];
            for(int i = 0;i<10;i++)
            {
                map[i] = Console.ReadLine();
            }
            int[] vx = new int[4] { 1, -1, 0, 0 };
            int[] vy = new int[4] { 0, 0, 1, -1 };

            for (int p = 0; p < 10; p++)
            {
                for (int q = 0; q < 10; q++)
                {
                    bool[,] check = new bool[10, 10];
                    int ans = 0;
                    Queue<int> qx = new Queue<int>();
                    Queue<int> qy = new Queue<int>();
                    for (int x = 0; x < 10; x++)
                    {
                        for (int y = 0; y < 10; y++)
                        {
                            if (check[x, y] == false)
                            {

                                check[x, y] = true;
                                if (map[y][x].ToString() == "o")
                                {
                                    ans += 1;
                                    qx.Enqueue(x);
                                    qy.Enqueue(y);
                                    while (qx.Count > 0)
                                    {
                                        int checkingx = qx.Dequeue();
                                        int checkingy = qy.Dequeue();
                                        for (int k = 0; k < 4; k++)
                                        {
                                            int nextx = checkingx + vx[k];
                                            int nexty = checkingy + vy[k];
                                            if (nextx >= 0 && nextx < 10 &&
                                                nexty >= 0 && nexty < 10 &&
                                                check[nextx, nexty] == false)
                                            {
                                                if (map[nexty][nextx].ToString() == "o" || (nextx == p && nexty == q))
                                                {
                                                    check[nextx, nexty] = true;
                                                    qx.Enqueue(nextx);
                                                    qy.Enqueue(nexty);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (ans == 1)
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                }
            }
            Console.WriteLine("NO");
        }
    }
}
