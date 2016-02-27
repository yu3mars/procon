using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2243
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string st = Console.ReadLine();
                if (st == "#") return;
                int[] s = new int[st.Length];
                for (int i = 0; i < st.Length; i++)
                {
                    s[i] += (st[i] - '1') % 3;
                }
                bool r = false;
                bool l = false;
                int ans = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == s[i - 1])
                    {
                        if (r || l)
                        {
                            r = !r;
                            l = !l;
                        }
                    }
                    else if (s[i] > s[i - 1])
                    {
                        if(r) 
                        {
                            ans++;
                        }
                        else
                        {
                            r = true;
                        }
                        l = false;
                    }
                    else if (s[i] < s[i - 1])
                    {
                        if (l)
                        {
                            ans++;
                        }
                        else
                        {
                            l = true;
                        }
                        r = false;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
