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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine().Replace("F","E");
            double ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ans += 'E' - s[i];
            }
            ans /= s.Length;
            Console.WriteLine(ans);
        }
    }
}
