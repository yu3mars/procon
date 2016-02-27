using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2006
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] h = new string[10];
            h[1] =".,!? ";
            h[2] = "abc";
            h[3] = "def";
            h[4] = "ghi";
            h[5] = "jkl";
            h[6] = "mno";
            h[7] = "pqrs";
            h[8] = "tuv";
            h[9] = "wxyz";
            for (int k = 0; k < n; k++)
            {
                string str = Console.ReadLine();
                string ans = "";
                int target = 0;
                int cnt = -1;
                for (int i = 0; i < str.Length; i++)
                {
                    int next = int.Parse(str[i].ToString());
                    if (next == 0)
                    {
                        if (target != 0)
                        {
                            ans += h[target][cnt % h[target].Length].ToString();
                            cnt = -1;
                        }
                        target = 0;
                    }
                    else
                    {
                        target = next;
                        cnt += 1;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
