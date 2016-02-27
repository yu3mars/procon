using System;

namespace b
{
    class P
    {
        static int[] u;
        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int c,x,y,i,n = int.Parse(s[0])+1, q = int.Parse(s[1]);
            u = new int[n];
            for (i = 0; i < n; i++)
            {
                u[i] = -1;
            }
            for (i = 0; i < q; i++)
            {
                string[] r = Console.ReadLine().Split(' ');
                c = int.Parse(r[0]); 
                x = int.Parse(r[1]);
                y = int.Parse(r[2]);
                
                if (c == 0)
                {
                    C(x, y);
                }
                else if (c == 1)
                {
                    Console.WriteLine(J(x, y) ? "YES" : "NO");
                }
            }
        }

        static int R(int a)
        {
            return u[a] < 0 ? a : u[a] = R(u[a]);
        }

        static void C(int a, int b)
        {
            int x = R(a), y = R(b);
            if (x == y)
            {
                return;
            }
            if (u[x] > u[y])
            {
                u[x] = y;
            }
            else
            {
                if (u[x] == u[y])
                {
                    u[x]--;
                }
                u[y] = x;
            }
        }

        static bool J(int a, int b)
        {
            return R(a) == R(b);
        }
    }
}
