using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vy = { 1, 0, -1, 0 };
            int[] vx = { 0, 1, 0, -1 }; 

            int[] rc=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = rc[0];
            int c = rc[1];
            int[] start=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] goal=Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < 2; i++)
            {
                start[i]--;
                goal[i]--;
            }
            string[] map = new string[r];
            int[,] kyori = new int[r, c];
            bool[,] check = new bool[r, c];
            for (int i = 0; i < r; i++)
            {
                map[i] = Console.ReadLine();
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    kyori[i, j] = int.MaxValue / 3;
                }
            }
            Queue<int> qx = new Queue<int>();
            Queue<int> qy = new Queue<int>();
            Queue<int> qd = new Queue<int>();
            qx.Enqueue(start[0]);
            qy.Enqueue(start[1]);
            qd.Enqueue(0);

            while(qx.Count>0)
            {
                int nowx = qx.Dequeue();
                int nowy = qy.Dequeue();
                int nowd = qd.Dequeue();
                kyori[nowx, nowy] = nowd;
                check[nowx, nowy] = true;
                int nextd = nowd + 1;
                for (int i = 0; i < 4; i++)
                {
                    int nextx = nowx + vx[i];
                    int nexty = nowy + vy[i];
                    if(map[nextx][nexty]=='.' && check[nextx,nexty]==false && nextd<kyori[nextx,nexty])
                    {
                        qx.Enqueue(nextx);
                        qy.Enqueue(nexty);
                        qd.Enqueue(nextd);
                        check[nextx, nexty] = true;
                    }
                }
            }
            Console.WriteLine(kyori[goal[0],goal[1]]);
        }
    }
}
