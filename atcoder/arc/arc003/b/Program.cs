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
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                Array.Reverse(chars);
                s[i] = new string(chars);
            }
            Array.Sort(s);
            for (int i = 0; i < n; i++)
            {
                char[] chars = s[i].ToCharArray();
                Array.Reverse(chars);
                string ans = new string(chars);
                Console.WriteLine(ans);
            }
        }
    }
}
