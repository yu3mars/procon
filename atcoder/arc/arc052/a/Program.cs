using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ans = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(0<=s[i]-'0' && s[i]-'0'<=9)
                {
                    ans += s[i];
                }
            }
            Console.WriteLine(ans);
        }
    }
}
