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
            long[] hwab = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long h = hwab[0];
            long w = hwab[1];
            long a = hwab[2];
            long b = hwab[3];
            long[][] map = new long[3][];
            for (int i = 0; i < 3; i++)
            {
                map[i] = new long[w + 1];
            }
            map[1][1] = 1;
            long mod = 1000000007;

            for (int x = 1; x <= h; x++)
            {
                map[(x + 1) % 3] = new long[w + 1];
                for (int y = 1; y <= w; y++)
                {
                    if ((x > 1 || y > 1) && (x < h - a + 1 || y > b))
                    {
                        map[x % 3][y] += map[(x - 1) % 3][y] + map[x % 3][y - 1];
                        map[x % 3][y] %= mod;
                    }
                }

            }
            Console.WriteLine(map[h % 3][w]);
        }
    }
}
