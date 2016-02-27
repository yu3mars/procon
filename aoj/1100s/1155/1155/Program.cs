using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1155
{
    class Program
    {
        static string s;
        static int point;
        static int p, q, r;
        static void Main(string[] args)
        {
            for (; ; )
            {
                s = Console.ReadLine();
                if (s == ".") return;
                int ans = 0;
                for (int i = 0; i < 3; i++)
                {
                    p = i;
                    for (int j = 0; j < 3; j++)
                    {
                        q = j;
                        for (int k = 0; k < 3; k++)
                        {
                            r = k;
                            point = 0;                            
                            if (Shiki() == 2)
                            {
                                ans++;
                            }
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }

        static int Shiki()
        {
            int tmp = Kou();
            while (point < s.Length)
            {
                if (s[point] == '+')
                {
                    point++;
                    tmp = Math.Max(tmp, Kou());
                }
                else if (s[point] == '*')
                {
                    point++;
                    tmp = Math.Min(tmp, Kou());
                }
                else break;
            }
            point++;
            return tmp;
        }

        static int Kou()
        {
            int tmp = Youso();
            while (point < s.Length)
            {
                if (s[point] == '-')
                {
                    point++;
                    tmp = 2 - Kou();
                }
                else break;
            }
            return tmp;
        }

        static int Youso()
        {
            int tmp = 0;
            if (s[point] == '(')
            {
                point++;
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
            if (point < s.Length)
            {
                if ('0' <= s[point] && s[point] <= '2')
                {
                    tmp = int.Parse(s[point].ToString());
                    point++;
                }
                else if (s[point] == 'P')
                {
                    tmp = p;
                    point++;
                }
                else if (s[point] == 'Q')
                {
                    tmp = q;
                    point++;
                }
                else if (s[point] == 'R')
                {
                    tmp = r;
                    point++;
                }
            }
            return tmp;
        }
        
    }
}
