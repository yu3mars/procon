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
            string s = Console.ReadLine().ToLower();
            string t = "ict";
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == t[cnt])
                {
                    cnt++;
                    if(cnt>2)
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                }
            }
            Console.WriteLine("NO");
        }
    }
}
