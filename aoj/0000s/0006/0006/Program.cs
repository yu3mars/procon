using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0006
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(reverseStr(str));
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
