using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if(s[0]==s[1])
            {
                Console.WriteLine("1 2");
                return;
            }
            for (int i = 0; i < s.Length-2; i++)
            {
                string t = s.Substring(i, 3);
                if(t[0] ==t[1] || t[1]==t[2] || t[2]==t[0])
                {
                    Console.WriteLine("{0} {1}", i + 1, i + 3);
                    return;
                }
            }
            Console.WriteLine("-1 -1");
        }
    }
}
