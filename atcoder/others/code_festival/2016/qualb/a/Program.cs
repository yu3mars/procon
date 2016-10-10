using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
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
            string s = sc.next();
            string a = "CODEFESTIVAL2016";
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (s[i] != a[i]) cnt++;
            }
            Console.WriteLine(cnt);
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