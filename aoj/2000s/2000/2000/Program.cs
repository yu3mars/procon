using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2000
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                bool[,] check = new bool[21, 21];
                string[][] str = new string[n][];
                int[] now = { 10, 10 };
                check[10, 10] = true;
                Dictionary<string, int> dirdic = new Dictionary<string, int>
                {
                    {"N",0},{"S",1},{"E",2},{"W",3}
                };
                int[] ns = { 1, -1, 0, 0 };
                int[] ew = { 0, 0, 1, -1 };

                for (int i = 0; i < n; i++)
                {
                    str[i] = Console.ReadLine().Split(' ');
                }
                int m = int.Parse(Console.ReadLine());

                for (int i = 0; i < m; i++)
                {
                    string[] dir = Console.ReadLine().Split(' ');
                    int nextdir = dirdic[dir[0]];
                    int moveint = int.Parse(dir[1]);
                    for (int j = 0; j < moveint; j++)
                    {
                        now[1] += ns[nextdir];
                        now[0] += ew[nextdir];
                        check[now[0], now[1]] = true;
                    }
                }

                bool ok = true;
                for (int i = 0; i < n; i++)
                {
                    int nextns = int.Parse(str[i][1]);
                    int nextew = int.Parse(str[i][0]);
                    if (check[nextew, nextns] == false)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok == true)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
