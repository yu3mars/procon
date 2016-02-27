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
            int n = int.Parse(Console.ReadLine());
            string[] sstr = new string[n];
            string[] estr = new string[n];
            int[] s = new int[n];
            int[] e = new int[n];
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                sstr[i] = tmp[0];
                estr[i] = tmp[1];
                s[i] = SECalc(sstr[i]);
                e[i] = SECalc(estr[i]);
            }
            int rbgn = 0;
            int rend = int.MaxValue - 100000;
            for (int i = 0; i < n; i++)
            {
                if (s[i] > e[i])
                {
                    rbgn = Math.Max(rbgn, s[i]);
                    rend = Math.Min(rend, e[i]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (s[i] > e[i])
                {
                    a[i] = e[i] - s[i] + 1000;
                }
                else if (s[i] >= rend +1000)
                {
                    a[i] = e[i] - s[i];
                }
                else if (e[i] + 1000 <= rbgn)
                {
                    a[i] = e[i] - s[i];
                }
                else if (s[i] <= rbgn && e[i] > rend)
                {
                    a[i] = e[i] - s[i] + 1000;
                }
                
                else
                {
                    a[i] = -1;
                }
                Console.WriteLine(a[i]);
            
            }

        }
        static int SECalc(string s)
        {
            int ans = 0;
            int h = int.Parse(s.Substring(0, 2));
            int m = int.Parse(s.Substring(3, 2));
            int sec = int.Parse(s.Substring(6, 2));
            int mm = int.Parse(s.Substring(9, 3));
            ans = mm + sec * 1000 + m * 1000 * 60 + h * 1000 * 60 * 60;
            return ans;
        }
    }
}
