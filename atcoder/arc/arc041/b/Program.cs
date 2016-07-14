using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vy = { 1, 0, -1, 0 };
            int[] vx = { 0, 1, 0, -1 }; 

            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            int[,] map = new int[n, m];
            int[,] ans = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    map[i, j] = s[j] - '0';
                }
            }
            for (int i = 1; i < n-1; i++)
            {
                for (int j = 1; j < m-1; j++)
                {
                    if(map[i-1,j]>0)
                    {
                        ans[i, j] = map[i - 1, j];
                        for (int k = 0; k < 4; k++)
                        {
                            map[i + vx[k], j + vy[k]] -= ans[i, j];
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(ans[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
