using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2590
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nmq = Console.ReadLine().Split(' ');
                int n = int.Parse(nmq[0]);
                int m = int.Parse(nmq[1]);
                int q = int.Parse(nmq[2]);
                if (n == 0 && m == 0 && q == 0) return;

                bool[,] map = new bool[n, m];
                bool[] onoff = new bool[n];
                for (int i = 0; i < q; i++)
                {
                    string[] sb = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        if (sb[0][j] == '1')
                        {
                            onoff[j] = !onoff[j];
                        }
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (onoff[j]==false)
                        {
                            for (int k = 0; k < m; k++)
                            {
                                if (sb[1][k] == '1')
                                {                                    
                                    map[j, k] = true;
                                }
                            }
                        }
                        else
                        {
                            for (int k = 0; k < m; k++)
                            {
                                if (sb[1][k] == '0')
                                {
                                    map[j, k] = true;
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < m; j++)
                {
                    int now = -1;
                    int count = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (map[i, j] == false)
                        {
                            now=i;
                            count += 1;
                        }
                    }
                    if (count > 1)
                    {
                        Console.Write("?");
                    }
                    else
                    {
                        if (now < 10) Console.Write(now);
                        else
                        {
                            char prt = Convert.ToChar('A' + now - 10);
                            Console.Write(prt);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
