using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0109
{
    class Program
    {
        static string s;
        static int p;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                p = 0;
                Console.WriteLine(Shiki());
            }
        }

        static int Shiki()
        {
            int tmp = Kou();
            while (p < s.Length)
            {
                if (s[p] == '+')
                {
                    p++;
                    tmp = tmp + Kou();
                }
                else if (s[p] == '-')
                {
                    p++;
                    tmp = tmp - Kou();
                }
                else break;
            }
            p++;
            return tmp;
        }

        static int Kou()
        {
            int tmp = Youso();
            while (p < s.Length)
            {
                if (s[p] == '*')
                {
                    p++;
                    tmp = tmp * Youso();
                }
                else if (s[p] == '/')
                {
                    p++;
                    tmp = tmp / Youso();
                }
                else break;
            }
            return tmp;
        }

        static int Youso()
        {
            int tmp = 0;
            if (s[p] == '(')
            {
                p++;
                tmp = Shiki();
            }
            else
            {
                tmp = Suuji();
            }
            return tmp;
        }

        static int Suuji()
        {
            int tmp = 0;
            while (p < s.Length &&'0' <= s[p] && s[p] <= '9')
            {
                tmp = tmp * 10;
                tmp += int.Parse(s[p].ToString());
                p++;
            }
            return tmp;
        }
        

    }
}
