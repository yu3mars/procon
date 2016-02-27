using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamWriter w = new StreamWriter(@"output-sample.txt"))
            {
                using (StreamReader r = new StreamReader(@"A-sample.in"))
                {
                    int t = int.Parse(r.ReadLine());
                    for (int i = 0; i < t; i++)
                    {
                        int n = int.Parse(r.ReadLine());
                        int ans = 0;
                        int now = 0;
                        if (n < 21)
                        {
                            ans = n;
                            w.WriteLine("Case #{0}: {1}", i + 1, ans);
                            continue;
                        }
                        else if (n < 100)
                        {
                            int dec10 = (n - 1) / 10;
                            now = 10 + dec10;
                            ans = now + 1;
                            now = RevInt(now);
                            ans += n - now;
                        }

                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
             
        }

        static int RevInt(int n)
        {
            for (int i = 0; i < 4; i++)
            {
                if (n == n / 10 * 10)
                {
                    n = n / 10;
                }
                else
                {
                    continue;
                }
            }
            char[] chr = n.ToString().ToCharArray();
            Array.Reverse(chr);
            var ret = new string(chr);
            int ans = int.Parse(ret.ToString());
            return ans;
        }
    }
}
