using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1193
{
    class Program
    {
        public static int[][] map;
        public static int ans;
        public static int h;

        static void Main(string[] args)
        {
            int[] zeroline = new int[] { 0, 0, 0, 0, 0 };
            for (; ; )
            {
                h = int.Parse(Console.ReadLine());
                if (h == 0) return;
                ans = 0;
                map = new int[h + 1][];
                map[0] = zeroline;
                for (int i = 1; i <= h; i++)
                {
                    string[] tmpmapstr = Console.ReadLine().Split(' ');
                    int[] tmpmapint = new int[5];
                    for (int j = 0; j < 5; j++)
                    {
                        tmpmapint[j] = int.Parse(tmpmapstr[j]);
                    }
                    map[i] = tmpmapint;
                }

                for (int cnt = 0; cnt < h; cnt++)
                {
                    for (int i = 1; i <= h; i++)
                    {
                        if (map[i][2] != 0)
                        {
                            int begin = 2;
                            int end = 2;
                            if (map[i][1] == map[i][2])
                            {
                                begin = 1;
                            }
                            if (begin == 1 && map[i][0] == map[i][1])
                            {
                                begin = 0;
                            }

                            if (map[i][2] == map[i][3])
                            {
                                end = 3;
                            }
                            if (end == 3 && map[i][3] == map[i][4])
                            {
                                end = 4;
                            }
                            if (end - begin > 1)
                            {
                                remove(i, begin, end);
                            }
                        }
                    }
                    refresh();
                }


                Console.WriteLine(ans);
            }
        }

        static void remove(int height,int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                ans += map[height][i];
                map[height][i] = 0;
            }
        }

        static void refresh()
        {
            for(int k=0;k<h+1;k++)
            {
                for (int i = h; i > 0; i--)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (map[i][j] == 0)
                        {
                            map[i][j] = map[i - 1][j];
                            map[i - 1][j] = 0;
                        }
                    }
                }
            }
        }

    }
}
