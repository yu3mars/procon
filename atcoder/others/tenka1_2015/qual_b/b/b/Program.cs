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
            if (s.Length == 2)
            {
                Console.WriteLine("dict");
                return;
            }
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    cnt += 1;
                }
                else if (s[i] == '}')
                {
                    cnt -= 1;
                }
                else if (cnt == 1 && s[i] == ':')
                {
                    Console.WriteLine("dict");
                    return;
                }
            }
            Console.WriteLine("set");
        }
    }
}
