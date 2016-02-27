using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static string[] map;
        static bool[,] check;
        static int[] dx = { 1, -1, 0, 0 };
        static int[] dy = { 0, 0, 1, -1 };
        static int[] start = new int[2];
        static int[] goal = new int[2];
        static int w, h;

        static void Main(string[] args)
        {
            string[] hw = Console.ReadLine().Split(' ');
            h = int.Parse(hw[0]);
            w = int.Parse(hw[1]);
            map = new string[h];
            check = new bool[h, w];

            for (int i = 0; i < h; i++)
            {
                map[i] = Console.ReadLine();
                for (int j = 0; j < w; j++)
                {
                    if (map[i][j] == 's')
                    {
                        start[0] = i;
                        start[1] = j;
                    }
                    else if (map[i][j] == 'g')
                    {
                        goal[0] = i;
                        goal[1] = j;
                    }
                }
            }
            DFS(start[0], start[1]);
            if (check[goal[0], goal[1]] == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static void DFS(int x, int y)
        {
            if (map[x][y] == '#' || check[x , y] == true) return;
            check[x, y] = true;

            for (int i = 0; i < 4; i++)
            {
                if (0 <= x + dx[i] && x + dx[i] < h
                    && 0 <= y + dy[i] && y + dy[i] < w)
                {
                    DFS(x + dx[i], y + dy[i]);
                }
            }
        }
    }
}
