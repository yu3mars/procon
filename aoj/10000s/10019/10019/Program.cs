using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10019
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string str = Console.ReadLine();
                if (str == "0")
                {
                    return;
                }
                int ans = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    ans += int.Parse(str[i].ToString());
                }
                Console.WriteLine(ans);
            }
        }
    }
}
