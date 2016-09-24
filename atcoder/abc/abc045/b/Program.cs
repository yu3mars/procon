using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[3];
            int[] cnt = new int[3];
            for (int i = 0; i < 3; i++)
            {
                s[i] = Console.ReadLine();
                cnt[i] = 0;
            }

            int now = 0;

            for(;;)
            {
                if(cnt[now] == s[now].Length)
                {
                    Console.WriteLine((char)('A' + now));
                    return;
                }
                cnt[now]++;
                now = s[now][cnt[now]-1] - 'a';
            }
        }
    }
}
