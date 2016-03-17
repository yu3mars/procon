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
            string s = Console.ReadLine() + "+";
            int ans = 0;
            bool zerofound = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+')
                {
                    if (zerofound) zerofound = false;
                    else ans++;
                }
                else if (s[i] == '0')
                {
                    zerofound = true;
                }
                
            }
            Console.WriteLine(ans);
        }
    }
}
