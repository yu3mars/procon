using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e
{
    class Program
    {
        static int h, w;
        static void Main(string[] args)
        {
            int[] vy = { 1, 0, -1, 0 };
            int[] vx = { 0, 1, 0, -1 };

            int ans = 0;

            int[] hw = Console.ReadLine().Split().Select(int.Parse).ToArray();
            h = hw[0];
            w = hw[1];
            string[] map = new string[h];
            for (int i = 0; i < h; i++)
            {
                map[i] = Console.ReadLine();
            }

            bool[,] saku = new bool[h, w];
            Queue<int> qsakux = new Queue<int>();
            Queue<int> qsakuy = new Queue<int>();

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    if (map[y][x] == 'X')
                    {
                        if(y==0||y==h-1 ||x==0||x==w-1)
                        {
                            Console.WriteLine(-1);
                            return;
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            int tmpy = y + vy[i];
                            int tmpx = x + vx[i];
                            if (inside(tmpy, tmpx) && saku[tmpy, tmpx] == false)
                            {
                                saku[tmpy, tmpx] = true;
                                qsakuy.Enqueue(tmpy);
                                qsakux.Enqueue(tmpx);
                            }
                        }
                    }
                }
            }
            while (qsakuy.Count > 0)
            {
                int nowsakuy = qsakuy.Dequeue();
                int nowsakux = qsakux.Dequeue();
                bool deletable = true;

                Queue<int> qx = new Queue<int>();
                Queue<int> qy = new Queue<int>();
                qx.Enqueue(nowsakux);
                qy.Enqueue(nowsakuy);
                while(qy.Count>0)
                {
                    int nowy = qy.Dequeue();
                    int nowx = qx.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int tmpy = nowy + vy[i];
                        int tmpx = nowx + vx[i];
                        if (inside(tmpy, tmpx) == false)
                        {
                            deletable = false;
                            break;
                        }
                        else if (saku[tmpy, tmpx] == false && map[tmpy][tmpx] == '.')
                        {
                            qy.Enqueue(tmpy);
                            qx.Enqueue(tmpx);
                        }
                    }
                    if (deletable == false) break;
                }

                if (deletable == false) ans++;
            }
            Console.WriteLine(ans);
        }
        static bool inside(int y, int x)
        {
            return y >= 0 && x >= 0 && y < h && x < w;
        }
    }
}
