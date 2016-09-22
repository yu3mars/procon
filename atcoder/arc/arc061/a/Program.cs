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
            long ans = 0;

            for (int bef = 0; bef < s.Length; bef++)
            {
                for (int len = 1; bef +len <= s.Length; len++)
                {
                    string substr = s.Substring(bef, len);
                    int aft = s.Length - bef - len;
                    long num = (long)(Math.Max(1, Math.Pow(2, bef - 1)) * 
                        Math.Max(1, Math.Pow(2, aft - 1)));
                    ans += long.Parse(substr) * num;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
