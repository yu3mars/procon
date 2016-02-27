using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string nstr = Console.ReadLine();
            long n = long.Parse(nstr);
            long nlen = nstr.Length;
            SortedSet<long> ans = new SortedSet<long>();
            for (long i = n - nlen * 10; i < n; i++)
            {
                if (func(i) == n)
                {
                    ans.Add(i);
                }
            }
            Console.WriteLine(ans.Count);
            foreach (long i in ans)
            {
                Console.WriteLine(i);
            }
        }

        static long func(long n)
        {
            if (n < 0)
            {
                return 0;
            }
            long ret = n;
            char[] nchr = n.ToString().ToCharArray();
            foreach (char c in nchr)
            {
                ret += long.Parse(c.ToString());
            }
            return ret;
        }
    }
}
