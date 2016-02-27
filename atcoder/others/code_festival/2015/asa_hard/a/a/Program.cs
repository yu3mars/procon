using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            List<long> w = new List<long>();
            List<long> b = new List<long>();
            long ans = 0;

            bool bbgn = false;
            bool bend = false;
            if (n % 2 == 0)
            {
                bend = true;
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    w.Add(long.Parse(s[i]));
                }
                else
                {
                    b.Add(long.Parse(s[i]));
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (i % 2 == 0)//put black
                {
                    if (bbgn == true)
                    {
                        ans += w[w.Count - 1];
                        b[b.Count - 1] += 1 + w[w.Count - 1];
                        w.RemoveAt(w.Count - 1);
                        bend = true;
                    }
                    else if (bend == true)
                    {
                        ans += w[0];
                        b[0] += 1 + w[0];
                        w.RemoveAt(0);
                        bend = false;

                    }
                    else if (w[0] <= w[w.Count - 1])
                    {
                        ans += w[0];
                        b[0] += 1 + w[0];
                        w.RemoveAt(0);
                        bend = false;

                    }
                    else
                    {
                        ans += w[w.Count - 1];
                        b[b.Count - 1] += 1 + w[w.Count - 1];
                        w.RemoveAt(w.Count - 1);
                        bend = true;

                    }
                }
                else
                {
                    if (bbgn == false)
                    {
                        ans += b[b.Count - 1];
                        w[w.Count - 1] += 1 + b[b.Count - 1];
                        b.RemoveAt(b.Count - 1);
                        bend = true;
                        
                    }
                    else if (bend == false)
                    {
                        ans += b[0];
                        w[0] += 1 + b[0];
                        b.RemoveAt(0);
                        bend = false;

                    }
                    else if (b[0] <= b[b.Count - 1])
                    {
                        ans += b[0];
                        w[0] += 1 + b[0];
                        b.RemoveAt(0);
                        bend = false;

                    }
                    else
                    {
                        ans += b[b.Count - 1];
                        w[w.Count - 1] += 1 + b[b.Count - 1];
                        b.RemoveAt(b.Count - 1);
                        bend = true;

                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
