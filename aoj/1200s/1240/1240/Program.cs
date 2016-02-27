using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1240
{
    class Program
    {
        static void Main(string[] args)
        {

            int qstr = int.Parse(Console.ReadLine());
            for (int q = 0; q < qstr; q++)
            {
                string tsk = Console.ReadLine();
                string x = Console.ReadLine();
                for (int i = tsk.Length - 1; i >= 0; i--)
                {
                    char y = tsk[i];
                    if (y == 'J')
                    {
                        x = j(x);
                    }
                    else if (y == 'C')
                    {
                        x = c(x);
                    }
                    else if (y == 'E')
                    {
                        x = e(x);
                    }
                    else if (y == 'A')
                    {
                        x = a(x);
                    }
                    else if (y == 'P')
                    {
                        x = p(x);
                    }
                    else if (y == 'M')
                    {
                        x = m(x);
                    }
                }
                Console.WriteLine(x);
            }
        }

        static string c(string str)
        {
            char[] chr = str.ToCharArray();
            string ans = "";
            for (int i = 1; i < chr.Length; i++)
            {
                ans += chr[i].ToString();
            }
            ans += chr[0].ToString();
            return ans;
        }

        static string j(string str)
        {
            char[] chr = str.ToCharArray();
            string ans = "";
            ans += chr[chr.Length - 1].ToString();
            for (int i = 0; i < chr.Length - 1; i++)
            {
                ans += chr[i].ToString();
            }
            return ans;
        }

        static string e(string str)
        {
            if (str.Length % 2 == 0)
            {
                int n = str.Length / 2;
                string mae = str.Substring(0, n);
                string ato = str.Substring(n);
                string ans = ato + mae;
                return ans;
            }
            else
            {
                int n = str.Length / 2;
                string mae = str.Substring(0, n);
                string naka = str.Substring(n, 1);
                string ato = str.Substring(n + 1);
                string ans = ato + naka + mae;
                return ans;
            }
        }

        static string a(string str)
        {
            char[] chr = str.ToCharArray();
            Array.Reverse(chr);
            string ans = new string(chr);
            return ans;
        }

        static string p(string str)
        {
            char[] chr = str.ToCharArray();
            string ans = "";
            for (int i = 0; i < chr.Length; i++)
            {
                int res = 0;
                if (int.TryParse(chr[i].ToString(), out res))
                {
                    res = (res + 9) % 10;
                    ans += res.ToString();
                }
                else
                {
                    ans += chr[i].ToString();
                }
            }
            return ans;
        }

        static string m(string str)
        {
            char[] chr = str.ToCharArray();
            string ans = "";
            for (int i = 0; i < chr.Length; i++)
            {
                int res = 0;
                if (int.TryParse(chr[i].ToString(), out res))
                {
                    res = (res +11) % 10;
                    ans += res.ToString();
                }
                else
                {
                    ans += chr[i].ToString();
                }
            }
            return ans;
        }
    }
}
