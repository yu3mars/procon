using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10018
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string ans = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    ans += char.ToLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    ans += char.ToUpper(str[i]);
                }
                else
                {
                    ans += str[i];
                }
            }
            Console.WriteLine(ans);
        }
    }
}
