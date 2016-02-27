using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rcm = Console.ReadLine().Split(' ');
            int ns = int.Parse(rcm[0]);
            int ew = int.Parse(rcm[1]);
            int m = int.Parse(rcm[2]);
            int n = int.Parse(Console.ReadLine());

            int[,] tejun = new int[n, 4];
            for (int i = 0; i < n; i++)
            {
                string[] tejunstr = Console.ReadLine().Split(' ');
                for (int j = 0; j < 4; j++)
                {
                    tejun[i, j] = int.Parse(tejunstr[j]);
                }
            }

            int[,] map = new int[ns, ew];
            for (int i = 0; i < n; i++)
            {
                for (int j = tejun[i, 0]; j <= tejun[i, 1]; j++)
                {
                    for (int k = tejun[i, 2]; k <= tejun[i, 3]; k++)
                    {
                        map[j-1, k-1] += 1;
                    }
                }
            }

            int cnttrue = 0;
            for (int i = 0; i < ns; i++)
            {
                for (int j = 0; j <ew; j++)
                {
                    if (map[i, j] % 4 == 0)
                    {
                        cnttrue += 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                int diff = 0;
                for (int j = tejun[i, 0]; j <= tejun[i, 1]; j++)
                {
                    for (int k = tejun[i, 2]; k <= tejun[i, 3]; k++)
                    {
                        if (map[j - 1, k - 1] % 4 == 0)
                        {
                            diff -= 1;
                        }
                        else if (map[j - 1, k - 1] % 4 == 1)
                        {
                            diff += 1;
                        }
                    }
                }
                if (cnttrue + diff == m)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}
