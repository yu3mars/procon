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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            if (s.Length % 2 > 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                int ans = 0;
                for (int i = 0; i < s.Length/2; i++)
                {
                    if (s[i] != s[s.Length / 2 + i])
                    {
                        ans++;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
