using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
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
            int n = sc.nextInt();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = sc.nextInt();
            }
            long ans = 0;
            int now = 1;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if(a[i] > now)
                {
                    ans += (a[i] - 1) / now;
                    max = Math.Max(max, 1);
                    now = max + 1;
                }
                else
                {
                    max = Math.Max(max, a[i]);
                    now = max + 1;
                }
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