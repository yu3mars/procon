using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1160
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int sizew = int.Parse(str[0]);
                int sizeh = int.Parse(str[1]);
                if (sizew == 0 && sizeh == 0)
                {
                    return;
                }
                string[][] map = new string[sizeh][];
                for (int i = 0; i < sizeh; i++)
                {
                    map[i] = Console.ReadLine().Split(' ');
                }
                bool[,] check = new bool[sizew,sizeh];
                Queue<int> qw = new Queue<int>();
                Queue<int> qh = new Queue<int>();
                int ans = 0;
                int[] vw = new int[9] { 1, 1, 1, -1, -1, -1, 0, 0, 0 };
                int[] vh = new int[9] { 0, 1, -1, 0, 1, -1, 0, 1, -1 };

                for (int i = 0; i < sizew; i++)
                {
                    for (int j = 0; j < sizeh; j++)
                    {

                        if (check[i, j] == false && map[j][i] == "1")
                        {
                            check[i, j] = true;
                            ans += 1;
                            qw.Enqueue(i);
                            qh.Enqueue(j);
                            while (qw.Count > 0)
                            {
                                int w = qw.Dequeue();
                                int h = qh.Dequeue();
                                for (int k = 0; k < vw.Length; k++)
                                {
                                    int nextw = w + vw[k];
                                    int nexth = h + vh[k];
                                    if (nextw >= 0 && nextw < sizew &&
                                        nexth >= 0 && nexth < sizeh &&
                                        check[nextw, nexth] == false &&
                                        map[nexth][nextw] == "1")
                                    {
                                        check[nextw, nexth] = true;
                                        qw.Enqueue(nextw);
                                        qh.Enqueue(nexth);
                                    }
                                }
                            }
                        }
                        else
                        {
                            check[i, j] = true;

                        }
                    }

                }
                Console.WriteLine(ans);
            }
        }
    }
}
