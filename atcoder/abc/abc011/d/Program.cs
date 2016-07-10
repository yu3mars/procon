using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vy = { 1, 0, -1, 0 };
            int[] vx = { 0, 1, 0, -1 }; 

            int[] nd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(xy[0]%nd[1]>0 || xy[1]%nd[1]>0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                xy[i] /= nd[1];
            }

            double[][,] dp = new double[2][,];
            for (int i = 0; i < 2; i++)
            {
                dp[i] = new double[2001, 2001];
            }
            dp[0][1000, 1000] = 1;
            for (int jump = 0; jump < nd[0]; jump++)
            {
                int next = (jump + 1) % 2;
                int now = jump % 2;
                dp[next] = new double[2001, 2001];
                for (int nowx = 1000 - jump; nowx < 1001 + jump; nowx++)
                {
                    for (int nowy = 1000 - jump; nowy < 1001 + jump; nowy++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            dp[next][nowx + vx[i], nowy + vy[i]] += dp[now][nowx, nowy] / 4.0;
                        }
                    }
                }
            }
            Console.WriteLine(dp[nd[0] % 2][xy[0] + 1000, xy[1] + 1000]);
        }
    }
}
