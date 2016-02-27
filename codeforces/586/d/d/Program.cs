using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int zzzz = int.Parse(Console.ReadLine());
            for (int zzz = 0; zzz < zzzz; zzz++)
            {
                Calc();
            }
        }

        private static void Calc()
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            string[] mapstr = new string[3];
            for (int i = 0; i < 3; i++)
            {
                mapstr[i] = Console.ReadLine();
            }
            bool[,] map = new bool[3, n + 3];
            bool[,] able = new bool[3, n + 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n + 3; j++)
                {
                    map[i, j] = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mapstr[i][j] != '.' && mapstr[i][j] != 's')
                    {
                        map[i, j] = false;
                    }
                }
            }
            //bool[] nowable = new bool[3];
            //bool[] oldable = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                if (mapstr[i][0] == 's')
                {
                    able[i, 0] = true;
                }
            }
            for (int j = 1; j < n + 2; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (map[i, j] == true && able[i, j - 1] == true)
                    {
                        able[i, j] = true;
                    }
                }
                //oldable = nowable;
                if (j % 3 == 1)
                {
                    bool[] nowable = new bool[3];

                    for (int i = 0; i < 3; i++)
                    {
                        if (map[i, j] == true)
                        {
                            if (i == 0 && able[1, j - 1] && able[1, j]) nowable[0] = true;
                            if (i == 1 && ((able[0, j - 1] && able[0, j]) ||
                                (able[2, j - 1] && able[2, j])))
                                nowable[1] = true;
                            if (i == 2 && able[1, j - 1] && able[1, j]) nowable[2] = true;
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (nowable[i]) able[i, j] = true;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (able[i, n] == true)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
