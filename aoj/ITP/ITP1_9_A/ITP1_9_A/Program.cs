using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITP1_9_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Console.ReadLine().ToLower();
            int ans = 0;
            for (; ; )
            {
                string next = Console.ReadLine();
                if (next == "END_OF_TEXT")
                {
                    break;
                }
                string[] str = next.Split(' ');
                foreach (string s in str)
                {
                    if (s.ToLower() == w)
                    {
                        ans += 1;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
