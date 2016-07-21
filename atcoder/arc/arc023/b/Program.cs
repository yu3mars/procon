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
            int[] rcd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = rcd[0];
            int c = rcd[1];
            int d = rcd[2];
            int[][] map = new int[r][];
            for (int i = 0; i < r; i++)
            {
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            int ans = 0;
            for (int rr = 0; rr < r; rr++)
            {
                for (int cc = 0; cc < c; cc++)
                {
                    if (rr + cc > d) break;
                    if(d%2 ==(rr+cc)%2)
                    {
                        ans = Math.Max(ans, map[rr][cc]);
                    }
                }
                if (rr > d) break;
            }
            Console.WriteLine(ans);
        }
    }
}
