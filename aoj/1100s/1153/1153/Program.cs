using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                if (n == 0 && m == 0)
                {
                    return;
                }
                int diff = 0;
                int[] lstaro = new int[n];
                int[] lshana = new int[m];
                for (int i = 0; i < n; i++)
                {
                    int s = int.Parse(Console.ReadLine());
                    lstaro[i] = s;
                    diff += s;
                }
                for (int i = 0; i < m; i++)
                {
                    int s = int.Parse(Console.ReadLine());
                    lshana[i] = s;
                    diff -= s;
                }
                int inf = 10000;
                int cataro = inf;
                int cahana = inf;
                int sum = cataro + cahana;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (diff - 2 * lstaro[i] + 2 * lshana[j] == 0)
                        {
                            if (lstaro[i] + lshana[j] < sum)
                            {
                                cataro = lstaro[i];
                                cahana = lshana[j];
                                sum = cataro + cahana;
                            }
                        }
                    }
                }
                if (sum == inf * 2)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine("{0} {1}", cataro, cahana);
                }
            }
        }
    }
}
