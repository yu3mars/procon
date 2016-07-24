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
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            char last = 'a';
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if(set.Contains(s))
                {
                    if (i % 2 == 0) Console.WriteLine("LOSE");
                    else Console.WriteLine("WIN");
                    return;
                }
                if(s[0] !=last && i> 0)
                {
                    if (i % 2 == 0) Console.WriteLine("LOSE");
                    else Console.WriteLine("WIN");
                    return;
                }
                set.Add(s);
                last = s[s.Length - 1];
            }
            Console.WriteLine("DRAW");
        }
    }
}
