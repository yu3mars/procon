using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') continue;
                if ('z' - s[i] < k)
                {
                    k -= ('z' - s[i] + 1);
                    s[i] = 'a';
                }
            }
            k %= 26;
            if (s[s.Length - 1] + k <= 'z')
            {
                s[s.Length - 1] = (char)(s[s.Length - 1] + k);
            }
            else
            {
                s[s.Length - 1] = (char)(s[s.Length - 1] + k - 26);
            }
            Console.WriteLine(s);
        }
    }
}
