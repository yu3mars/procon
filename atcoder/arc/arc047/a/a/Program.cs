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
            string[] nl = Console.ReadLine().Split(' ');
            int n = int.Parse(nl[0]);
            int l = int.Parse(nl[1]);
            int now = 1;
            int ans = 0;
            string s = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '+')
                {
                    now++;
                    if (now > l)
                    {
                        ans++;
                        now = 1;
                    }
                }
                else if (s[i] == '-')
                {
                    now--;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
