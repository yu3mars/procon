using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2600
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nwh = Console.ReadLine().Split(' ');
            int n = int.Parse(nwh[0]);
            int w = int.Parse(nwh[1]);
            int h = int.Parse(nwh[2]);
            int[] wl = new int[w + 1];
            int[] hl = new int[h + 1];
            for (int i = 0; i < n; i++)
            {
                string[] xyw = Console.ReadLine().Split(' ');
                int x = int.Parse(xyw[0]);
                int y = int.Parse(xyw[1]);
                int z = int.Parse(xyw[2]);
                wl[Math.Max(0, x - z)] += 1;
                hl[Math.Max(0, y - z)] += 1;
                if (x + z < w)
                {
                    wl[x + z] -= 1;
                }
                if (y + z < h)
                {
                    hl[y + z] -= 1;
                }
            }
            bool ngx = false;
            bool ngy = false;
            int cnt = 0;
            for (int i = 0; i <= w; i++)
            {
                cnt += wl[i];
                if (cnt < 1)
                {
                    ngx = true;
                }
            }
            cnt = 0;
            for (int i = 0; i <= h; i++)
            {
                cnt += hl[i];
                if (cnt < 1)
                {
                    ngy = true;
                }
            }
            if (ngx == true && ngy == true)
            {
                Console.WriteLine("No");
            }
            else 
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
