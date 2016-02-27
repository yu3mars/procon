using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cut = Console.ReadLine().Split(' ');
            int[] cutx = new int[2];
            int[] cuty = new int[2];
            for (int i = 0; i < 2; i++)
            {
                cutx[i] = int.Parse(cut[i * 2]);
                cuty[i] = int.Parse(cut[i * 2 + 1]);
            }
            
            int n = int.Parse(Console.ReadLine());
            int[] tenx = new int[n + 1];
            int[] teny = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                string[] tenxy = Console.ReadLine().Split(' ');
                tenx[i] = int.Parse(tenxy[0]);
                teny[i] = int.Parse(tenxy[1]);
            }
            tenx[n] = tenx[0];
            teny[n] = teny[0];
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if(isCross(tenx,teny,cutx,cuty,i))
                {
                    cnt += 1;
                }
            }
            Console.WriteLine(cnt/2+1);

        }

        static bool isCross(int[] tenx, int[] teny, int[] cutx, int[] cuty, int i)
        {
            int x1 = tenx[i];
            int x2 = tenx[i + 1];
            int x3 = cutx[0];
            int x4 = cutx[1];
            int y1 = teny[i];
            int y2 = teny[i + 1];
            int y3 = cuty[0];
            int y4 = cuty[1];

            int s1 = gets(x1, y1, x2, y2, x3, y3);
            int s2 = gets(x1, y1, x2, y2, x4, y4);

            if ((long)s1 * s2 > 0)
            {
                return false;
            }

            int s3 = gets(x3, y3, x4, y4, x1, y1);
            int s4 = gets(x3, y3, x4, y4, x2, y2);

            if ((long)s3 * s4 > 0)
            {
                return false;
            }

            return true;


        }

        static int gets(int ax,int ay,int bx,int by,int cx,int cy)
        {
            int x1 = ax - cx;
            int x2 = bx - cx;
            int y1 = ay - cy;
            int y2 = by - cy;
            return (x1 * y2) - (x2 * y1);
        }
    }
}
