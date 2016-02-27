using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1166
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] size = Console.ReadLine().Split(' ');
                int sizew = int.Parse(size[0]);
                int sizeh = int.Parse(size[1]);
                if (sizew == 0 && sizeh == 0)
                {
                    return;
                }
                
                char[][] map = new char[2*sizeh+2][];
                for (int i = 0; i < 2 * sizeh-1; i++)
                {
                    map[i] = Console.ReadLine().ToCharArray();
                }
                Queue<int> qw = new Queue<int>();
                Queue<int> qh = new Queue<int>();
                qw.Enqueue(1);
                qh.Enqueue(1);
                                
                int[,] count = new int[sizew + 2, sizeh + 2];
                for (int i = 0; i < sizew + 2; i++)
                {
                    count[i, 0] = -1;
                    count[i, sizeh + 1] = -1;
                }
                for (int i = 0; i < sizeh + 2; i++)
                {
                    count[0, i] = -1;
                    count[sizew + 1, i] = -1;
                }
                count[1, 1] = 1;
                while (qw.Count > 0)
                {
                    int w = qw.Dequeue();
                    int h = qh.Dequeue();
                    //ue
                    if (count[w, h - 1] == 0 && map[(h - 1) * 2 - 1][(w - 1) * 2].ToString() == "0")
                    {
                        qw.Enqueue(w);
                        qh.Enqueue(h - 1);
                        count[w, h - 1] = count[w, h] + 1;
                    }
                    //shita
                    if (count[w, h + 1] == 0 && map[(h - 1) * 2 + 1][(w - 1) * 2].ToString() == "0")
                    {
                        qw.Enqueue(w);
                        qh.Enqueue(h + 1);
                        count[w, h + 1] = count[w, h] + 1;                                          
                    }
                    //migi
                    if (count[w + 1, h] == 0 && map[(h - 1) * 2][(w - 1) * 2+1].ToString() == "0")
                    {
                        qw.Enqueue(w + 1);
                        qh.Enqueue(h);
                        count[w + 1, h] = count[w, h] + 1;                                            
                    }
                    //hidari
                    if (count[w - 1, h] == 0 && map[(h - 1) * 2][(w - 1) * 2 - 1].ToString() == "0")
                    {
                        qw.Enqueue(w - 1);
                        qh.Enqueue(h);
                        count[w - 1, h] = count[w, h] + 1;
                    }
                }
                Console.WriteLine(count[sizew, sizeh]);
            }
        }
    }
}
