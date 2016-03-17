using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] r = new int[n];
            int[] h = new int[n];
            int[] upper = new int[100001];
            int[] lower = new int[100001];
            int[,] data = new int[100001, 4];
            for (int i = 0; i < n; i++)
            {
                string[] rh = Console.ReadLine().Split(' ');
                r[i] = int.Parse(rh[0]);
                h[i] = int.Parse(rh[1]);
                data[r[i], h[i]]++;
                data[r[i], 0]++;
            }
            for (int i = 0; i < 100000; i++)
            {
                lower[i + 1] = lower[i] + data[i, 0];
            }
            for (int i = 100000; i > 0; i--)
            {
                upper[i - 1] = upper[i] + data[i, 0];
            }
            for (int i = 0; i < n; i++)
            {
                int win = lower[r[i]];
                int lose = upper[r[i]];
                int draw = data[r[i], h[i]] - 1;
                if (h[i] == 1)
                {
                    win += data[r[i], h[i] + 1];
                    lose += data[r[i], h[i] + 2];
                }
                if (h[i] == 2)
                {
                    win += data[r[i], h[i] + 1];
                    lose += data[r[i], h[i] - 1];
                } if (h[i] == 3)
                {
                    win += data[r[i], h[i] - 2];
                    lose += data[r[i], h[i] - 1];
                }
                Console.WriteLine("{0} {1} {2}", win, lose, draw);
            }
        }
    }
}
