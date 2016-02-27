using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int ans = 0;
            int stk0 = 0;
            int stk1 = 0;
            int i=0;
            while(i < s.Length)
            {
                if (i == s.Length - 1)
                {
                    i++;
                    break;
                }
                if (s[i] == '0' && s[i+1] =='1')
                {
                    i++;
                }
                else if (s[i] == '1' && s[i + 1] == '0')
                {
                    i++;
                }
                else if (s[i] == '0')
                {
                    if (stk0 > 0)
                    {
                        stk0--;
                    }
                    else
                    {
                        stk1++;
                        ans++;
                    }
                }
                else
                {
                    if (stk1 > 0)
                    {
                        stk1--;
                    }
                    else
                    {
                        stk0++;
                        ans++;
                    }
                }
                i++;
            }

            Console.WriteLine(ans);
        }
    }
}
