using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int tar = int.Parse(Console.ReadLine());
            int[] ls = new int[31];
            int lsnow = 1;
            for (int i = 0; i < ls.Length; i++)
            {
                ls[i] = lsnow;
                lsnow *= 2;
            }
            bool start = false;
            string ans = "";
            for (int i = ls.Length - 1; i >= 0; i--)
            {
                if (tar - ls[i] >= 0)
                {
                    tar -= ls[i];
                    ans += "1";
                    start = true;
                }
                else
                {
                    if (start == true)
                    {
                        ans += "0";
                    }
                }
            }
            string rev = reverseStr(ans);
            if (ans == rev)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static string reverseStr(string str)
        {
            char[] chr = str.ToCharArray();
            Array.Reverse(chr);
            string ans = new string(chr);
            return ans;
        }
    }
}
