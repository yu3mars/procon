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
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int cnts = 0;
            bool change = false;
            if (s[0] != t[0])
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (cnts < s.Length)
                {
                    if (s[cnts] == t[i])
                    {
                        if (s[cnts] != s[0])
                        {
                            change = true;
                        }
                        cnts += 1;
                    }
                    else if (change == false && t[i] == t[i - 1])
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else
                {
                    if (change == false && t[i] == t[i - 1])
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
            }
            if (cnts == s.Length)
            {
                Console.WriteLine("Yes");
                return;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }
        }
    }
}
