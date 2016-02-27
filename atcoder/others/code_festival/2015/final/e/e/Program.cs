using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ans = "";
            int b = 0;
            int m = 0;
            for (int i = s.Length-1; i >=0; i--)
            {
                if (s[i] == '!')
                {
                    b++;
                    m = 0;
                }
                else
                {
                    m++;
                }
            }

            if (b > 1)
            {
                if (b % 2 == 0)
                {
                    b = 2;
                }
                else
                {
                    b = 1;
                }
            }
            m %= 2;
            for (int i = 0; i < m; i++)
            {
                ans += "-";
            }
            for (int i = 0; i < b; i++)
            {
                ans += "!";
            }
            Console.WriteLine(ans);
        }
    }
}
