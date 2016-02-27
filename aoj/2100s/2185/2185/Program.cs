using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2185
{
    class Program
    {
        static void Main(string[] args)
        {
            int dataset = int.Parse(Console.ReadLine());
            for (int z = 0; z < dataset; z++)
            {
                string[] xywh = Console.ReadLine().Split(' ');
                int x = int.Parse(xywh[0]);
                int y = int.Parse(xywh[1]);
                int w = int.Parse(xywh[2]);
                int h = int.Parse(xywh[3]);
                int xx = x + w;
                int yy = y + h;
                int ans = 0;
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] ab = Console.ReadLine().Split(' ');
                    int a = int.Parse(ab[0]);
                    int b = int.Parse(ab[1]);
                    if (x <= a && a <= xx && 
                        y <= b && b <= yy)
                    {
                        ans += 1;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
