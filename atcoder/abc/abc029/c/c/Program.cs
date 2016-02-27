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
            ls(n, "");
        }
        static void ls(int n, string s)
        {
            if (n == 0)
            {
                Console.WriteLine(s);
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                char c = (char)('a' + i);
                ls(n - 1, s + c);
            }
        }
    }
}
