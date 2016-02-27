using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0002
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string str = Console.ReadLine();
                if (str == null)
                {
                    return;
                }
                string[] s = str.Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                int sum = a + b;
                int ans = sum.ToString().Length;
                Console.WriteLine(ans);
            }
        }
    }
}
