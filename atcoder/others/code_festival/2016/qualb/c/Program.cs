using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        public static int Main()
        {
            new Program().calc();
            return 0;
        }

        Scanner sc;

        public void calc()
        {
            sc = new Scanner();
            int w = sc.nextInt();
            int h = sc.nextInt();
            long ans = 0;


            int[] p = new int[w];
            int[] q = new int[h];
            for (int i = 0; i < w; i++)
            {
                p[i] = sc.nextInt();
            }
            for (int i = 0; i < h; i++)
            {
                q[i] = sc.nextInt();
            }
            Array.Sort(p);
            Array.Sort(q);
            int x = 0, y = 0;
            while (x < w && y < h)
            {
                if (p[x] <= q[y])
                {
                    ans += p[x] * (h + 1L - y);
                    x++;
                }
                else
                {
                    ans += q[y] * (w + 1L - x);
                    y++;
                }
            }
            while (x<w)
            {
                ans += p[x];
                x++;
            }
            while (y<h)
            {
                ans += q[y];
                y++;
            }
            Console.WriteLine(ans);
        }
    }


    class Scanner
    {
        string[] s;
        int i;

        char[] cs = new char[] { ' ' };

        public Scanner()
        {
            s = new string[0];
            i = 0;
        }

        public string next()
        {
            while (i >= s.Length)
            {
                string st = Console.ReadLine();
                while (st == "") st = Console.ReadLine();
                s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
                i = 0;
            }
            return s[i++];
        }

        public int nextInt()
        {
            return int.Parse(next());
        }

        public long nextLong()
        {
            return long.Parse(next());
        }

        public double nextDouble()
        {
            return double.Parse(next());
        }

    }
}