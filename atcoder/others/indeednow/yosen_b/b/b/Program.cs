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
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int ans = 0;
            bool ok = false;

            if (s.Length == t.Length)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s == t)
                    {
                        ok = true;
                        break;
                    }
                    string s1 = s.Substring(0, s.Length - 1);
                    string s2 = s.Substring(s.Length - 1);
                    s = s2 + s1;
                    ans += 1;
                }
            }
            if (ok == true)
            {
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
