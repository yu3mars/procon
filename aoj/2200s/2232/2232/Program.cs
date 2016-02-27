using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2232
{
    class Program
    {
        static int h, w, n;
        static string[] map, tmp;
        static void Main(string[] args)
        {
            string[] hwn = Console.ReadLine().Split(' ');
            h = int.Parse(hwn[0]);
            w = int.Parse(hwn[1]);
            n = int.Parse(hwn[2]);
            map = new string[h];
            tmp = new string[h];

            for (int i = 0; i < h; i++)
            {
                map[i] = Console.ReadLine();
            }
            for (int i = 0; i < h; i++)//yoko swap
            {
                for (int j = 0; j < w-1; j++)
                {
                    if (judge(i, j, i, j + 1)) return;
                }
            }
            Console.WriteLine("NO");
        }

        static void changeMap(int x1, int y1, char c)
        {
            string s1 = tmp[x1].Substring(0, y1);
            string s2 = tmp[x1].Substring(y1 + 1);
            tmp[x1] = s1 + c + s2;
        }
        static void swapChar(int x1, int y1, int x2, int y2)
        {
            char c1 = tmp[x1][y1];
            changeMap(x1, y1, tmp[x2][y2]);
            changeMap(x2, y2, c1);
        }

        static bool del()
        {
            bool[,] delable = new bool[h, w];
            bool change = false;
            for (int i = 0; i < h; i++)//yoko judge
            {
                for (int j = 0; j < w + 1 - n; j++)
                {
                    bool same = true;
                    for (int k = 0; k < n; k++)
                    {
                        if (tmp[i][j + k] == '.' || tmp[i][j + k] != tmp[i][j])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same == true)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            delable[i, j + k] = true;
                        }
                    }
                }
            }
            for (int j = 0; j < w; j++)//tate judge
            {
                for (int i = 0; i < h + 1 - n; i++)
                {
                    bool same = true;
                    for (int k = 0; k < n; k++)
                    {
                        if (tmp[i + k][j] == '.' || tmp[i + k][j] != tmp[i][j])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same == true)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            delable[i + k, j] = true;
                        }
                    }
                }
            }
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (delable[i, j] == true)
                    {
                        change = true;
                        changeMap(i, j, '.');
                    }
                }
            }
            return change;
        }
        static void fall()
        {
            for (int i = h - 1; i > 0; i--)
            {
                for (int j = 0; j < w; j++)
                {
                    if (tmp[i][j] == '.' && tmp[i - 1][j] != '.')
                    {
                        for (int k = i; k < h; k++)
                        {
                            if (tmp[k][j] == '.' && tmp[k - 1][j] != '.')
                            {
                                swapChar(k, j, k - 1, j);
                            }
                        }
                    }
                }
            }
        }
        static bool judge(int x1, int y1, int x2, int y2)
        {
            if (map[x1][y1] == map[x2][y2]) return false;
            map.CopyTo(tmp, 0);
            swapChar(x1, y1, x2, y2);
            
            for (; ; )
            {
                fall();
                bool delete = del();
                if (delete == false) break;
            }
            
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (tmp[i][j] != '.')
                    {
                        return false;
                    }
                }
            }
            Console.WriteLine("YES");
            return true;
        }
    }
}
