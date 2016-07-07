using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSL_1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = int.Parse(str[0]);
            int q = int.Parse(str[1]);
            int[] uni = new int[n];
            for (int i = 0; i < uni.Length; i++)
            {
                uni[i] = -1;
            }
            for (int i = 0; i < q; i++)
            {
                string[] que = Console.ReadLine().Split(' ');
                int com = int.Parse(que[0]);
                int x = int.Parse(que[1]);
                int y = int.Parse(que[2]);
                if (com == 0)
                {
                    Connect(x, y, uni);
                }
                else if (com == 1)
                {
                    if(IsConnect(x,y,uni))
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
        }

        static int Root(int a, int[] uni)
        {
            if (uni[a] < 0)
            {
                return a;
            }
            else
            {
                return uni[a] = Root(uni[a],uni);
            }
        }

        static void Connect(int a, int b,int[] uni)
        {
            int ra = Root(a, uni);
            int rb = Root(b, uni);
            if (ra == rb)
            {
                return;
            }
            if (uni[ra] > uni[rb])
            {
                uni[ra] = rb;
            }
            else
            {
                if (uni[ra] == uni[rb])
                {
                    uni[ra] -= 1;
                }
                uni[rb] = ra;
            }
        }

        static bool IsConnect(int a, int b, int[] uni)
        {
            return Root(a,uni) == Root(b,uni);
        }
    }
}
