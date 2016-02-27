using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            for (int querynum = 0; querynum < q; querynum++)
            {
                string[] s = Console.ReadLine().Split(' ');
                bool[] used = new bool[26];
                for (int i = 0; i < s[1].Length; i++)
                {
                    used[s[1][i] - 'a'] = true;
                }
                int cnt0 = 0;
                int cnt1 = 0;
                while (cnt0 < s[0].Length && cnt1 < s[1].Length)
                {
                    if (s[0][cnt0] == s[1][cnt1])
                    {
                        cnt0++;
                        cnt1++;
                    }
                    else
                    {
                        if (cnt1 > 0 && used[s[0][cnt0] - 'a'] == true)
                        {
                            cnt1 = 0;
                        }
                        else
                        {
                            cnt0++;
                        }                        
                    }
                }
                if (cnt1 == s[1].Length)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
