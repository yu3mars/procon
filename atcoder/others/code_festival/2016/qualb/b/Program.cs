using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
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
            int a = sc.nextInt();
            int b = sc.nextInt();
            string s = sc.next();
            int kokunai = 0;
            int kaigai = 0;
            for (int i = 0; i < n; i++)
            {
                if(s[i]=='a')
                {
                    if(kokunai < a + b)
                    {
                        Console.WriteLine("Yes");
                        kokunai++;
                    }
                    else Console.WriteLine("No");
                }
                else if(s[i] == 'b')
                {
                    if (kokunai < a + b && kaigai < b)
                    {
                        Console.WriteLine("Yes");
                        kokunai++;
                        kaigai++;
                    }
                    else Console.WriteLine("No");
                }
                else Console.WriteLine("No");

            }

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