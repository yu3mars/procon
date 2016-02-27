using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            for (int k = 0; k < m; k++)
            {
                string origin = Console.ReadLine();
                HashSet<string> set = new HashSet<string>();
                set.Add(origin);
                for (int i = 1; i < origin.Length; i++)
                {
                    string mae = origin.Substring(0, i);
                    string ato = origin.Substring(i);
                    set.Add(ato + mae);
                    set.Add(ato + reverseStr(mae));
                    set.Add(reverseStr(ato) + mae);
                    set.Add(reverseStr(ato) + reverseStr(mae));
                    set.Add(mae + reverseStr(ato));
                    set.Add(reverseStr(mae) + ato);
                    set.Add(reverseStr(mae) + reverseStr(ato));
                }
                int ans = set.Count;
                Console.WriteLine(ans);
            }
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
