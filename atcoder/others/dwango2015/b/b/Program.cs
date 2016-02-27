using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int ans = 0;
            int now =0;
            bool cont = true;
            bool now2 = false;
            bool now5 = false;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == '2')
                {
                    if (cont == true && now5 ==true)
                    {
                        now2 = true;
                        now5 = false;
                    }
                    else
                    {
                        ans += Exnow(now);
                        cont = true;
                        now2 = true;
                        now5 = false;
                        now = 0;
                    }
                }
                else if (c == '5')
                {
                    if (now2 == true)
                    {
                        now += 1;
                        now2 = false;
                        now5 = true;
                        cont = true;
                    }
                    else
                    {
                        ans += Exnow(now);
                        cont = false;
                        now2 = false;
                        now5 = false;
                        now = 0;
                    }
                }
                else
                {
                    ans += Exnow(now);
                    cont = false;
                    now2 = false;
                    now5 = false;
                    now = 0;
                }
            }
            if (now > 0)
            {
                ans += Exnow(now);
            }
            cont = false;
            now2 = false;
            now5 = false;
            now = 0;

            Console.WriteLine(ans);
        }

        static int Exnow(int now)
        {
            int answ = 0;
            for (int i = now; i > 0; i--)
            {
                answ += i;
            }
            return answ;
        }
    }
}
