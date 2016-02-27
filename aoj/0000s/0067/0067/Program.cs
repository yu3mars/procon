using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0067
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                char[][] map = new char[12][];
                bool[,] check = new bool[12, 12];
                int ans = 0;
                for (int i = 0; i < 12; i++)
                {
                    string str = Console.ReadLine();
                    if (str == null)
                    {
                        return;
                    }
                    else
                    {
                        map[i] = str.ToCharArray();
                    }
                }
                Queue<int> qx = new Queue<int>();
                Queue<int> qy = new Queue<int>();
                int[] vx = new int[4] { 1, -1, 0, 0 };
                int[] vy = new int[4] { 0, 0, 1, -1 };

                for (int x = 0; x < 12; x++)
                {
                    for (int y = 0; y < 12; y++)
                    {
                        if (check[x, y] == false)
                        {

                            check[x, y] = true;
                            if (map[y][x].ToString() == "1")
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
                                        if (nextx >= 0 && nextx < 12 &&
                                            nexty >= 0 && nexty < 12 &&
                                            check[nextx, nexty] == false &&
                                            map[nexty][nextx].ToString() == "1")
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

                Console.WriteLine(ans);
                Console.ReadLine();
            }
        }
    }
}
