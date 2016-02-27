using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            long a = long.Parse(str[0]);
            string astr = str[0];
            int k = int.Parse(str[1]);
            long ans = long.MaxValue;
            List<long> ls = new List<long>();
            char[] achr = a.ToString().ToCharArray();
            for (int p = 0; p < achr.Length; p++)
            {                
                for (int q = 0; q <= 9; q++)
                {                   
                    for (int r = 0; r <= 9; r++)
                    {
                        string tmp = "";
                        for (int m = 0; m < p; m++)
                        {
                            tmp += achr[m].ToString();
                        }
                        tmp += q;
                        for (int l = p + 1; l <= achr.Length; l++)
                        {
                            tmp += r.ToString();
                            long tmpi = long.Parse(tmp);
                            ls.Add(tmpi);
                        }
                    }
                }
            }
            for (int i = 0; i < ls.Count; i++)
            {
                char[] tchr = ls[i].ToString().ToCharArray();
                HashSet<char> hset = new HashSet<char>();
                foreach (char c in tchr)
                {
                    hset.Add(c);
                }
                if (hset.Count <= k)
                {
                    ans = Math.Min(ans,Math.Abs(ls[i]-a));
                }
            }
            Console.WriteLine(ans);
        }
    }
}
