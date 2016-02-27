using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1336
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nl = Console.ReadLine().Split(' ');
                int n = int.Parse(nl[0]);
                if (n == 0) return;
                int l = int.Parse(nl[1]);
                bool[] right = new bool[n];
                int[] map = new int[n];
                for (int i = 0; i < n; i++)
                {
                    string[] dandp = Console.ReadLine().Split(' ');
                    if (dandp[0] == "R")
                    {
                        right[i] = true;
                    }
                    map[i] = int.Parse(dandp[1]);
                }

                int ant = -1;
                for (int ans = 1; ; ans++)
                {
                    int antr = -1;
                    int antl = -1;
                    List<int>[] ls = new List<int>[l];
                    for (int i = 0; i < l; i++)
                    {
                        ls[i] = new List<int>();
                    }
                    for (int i = 0; i < n; i++)//ugokasu
                    {
                        if (right[i]) map[i]++;
                        else map[i]--;
                        if (0 < map[i] && map[i] < l)
                        {
                            ls[map[i]].Add(i);
                        }
                        else if (map[i] == 0)
                        {
                            antl = i;
                        }
                        else if (map[i] == l)
                        {
                            antr = i;
                        }
                    }
                    for (int i = 0; i < l; i++) //narabikae
                    {
                        if (ls[i].Count > 1)
                        {
                            foreach (int x in ls[i])
                            {
                                if (right[x] == true) right[x] = false;
                                else right[x] = true;
                            }
                        }
                    }
                    bool fin = true;
                    for (int i = 0; i < n; i++)
                    {
                        if (0 < map[i] && map[i] < l)
                        {
                            fin = false;
                            break;
                        }
                    }
                    if (fin == true)
                    {
                        if (antl >= 0) ant = antl;
                        else ant = antr;
                        Console.WriteLine("{0} {1}", ans, ant + 1);
                        break;
                    }
                }
            }
        }
    }
}
