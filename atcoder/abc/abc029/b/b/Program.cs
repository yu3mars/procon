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
            int ans = 0;
            for (int i = 0; i < 12; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == 'r')
                    {
                        ans++;
                        break;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
