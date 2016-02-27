using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2311
{
    class Program
    {
        static string[] map, next, tmp, tmp2;
        static bool mdone, cdone;
        static int[] x = { -1, -1, -1, 0, 0, 1, 1, 1 };
        static int[] y = { -1, 0, 1, -1, 1, -1, 0, 1 };
        
        static void Main(string[] args)
        {
            map = new string[8];
            next = new string[8];
            tmp = new string[8];
            tmp2 = new string[8];
            for (int i = 0; i < 8; i++)
            {
                map[i] = Console.ReadLine();
            }
            map.CopyTo(next, 0);
            map.CopyTo(tmp, 0);
            map.CopyTo(tmp2, 0);
            mdone = true;
            cdone = true;
            while (mdone || cdone)
            {
                mdone = mturn();
                cdone = cturn();
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(map[i]);
            }
        }

        static void changeMap(int x1, int y1, char c, string[] mapstr)
        {
            string s1 = mapstr[x1].Substring(0, y1);
            string s2 = mapstr[x1].Substring(y1 + 1);
            mapstr[x1] = s1 + c + s2;
        }
        static bool inMap(int a,int b)
        {
            if (0 <= a && a < 8 && 0 <= b && b < 8) return true;
            else return false;
        }
        static bool mturn()
        {
            int cnt = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int cnttmp = judge(i, j, 'o');
                    if (cnt < cnttmp)
                    {
                        tmp.CopyTo(next, 0);
                        cnt = cnttmp;
                    }
                }
            }
            if (cnt > 0)
            {
                next.CopyTo(map, 0);
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool cturn()
        {

            int cnt = 0;
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 7; j >= 0; j--)
                {
                    int cnttmp = judge(i, j, 'x');
                    if (cnt < cnttmp)
                    {
                        tmp.CopyTo(next, 0);
                        cnt = cnttmp;
                    }
                }
            }
            if (cnt > 0)
            {
                next.CopyTo(map, 0);
                return true;
            }
            else
            {
                return false;
            }
        }

        static int judge(int a, int b, char myc)
        {
            if (map[a][b] != '.') return 0;
            char enec;
            if (myc == 'o') enec = 'x';
            else enec = 'o';
            map.CopyTo(tmp, 0);
            changeMap(a, b, myc, tmp);

            int cnt = 0;
            for (int i = 0; i < 8; i++)
            {
                int ctmp = 0;
                int xnext = a + x[i];
                int ynext = b + y[i];
                tmp.CopyTo(tmp2, 0);
                if (inMap(xnext,ynext) == false ||
                    map[xnext][ynext] != enec) continue;
                while (inMap(xnext, ynext))
                {
                    if (map[xnext][ynext] == enec)
                    {
                        ctmp++;
                        changeMap(xnext, ynext, myc, tmp2);
                        xnext += x[i];
                        ynext += y[i];                        
                    }
                    else if (map[xnext][ynext] == myc)
                    {
                        cnt += ctmp;
                        tmp2.CopyTo(tmp, 0);
                        break;
                    }
                    else break;
                }
            }
            return cnt;
        }
    }
}
