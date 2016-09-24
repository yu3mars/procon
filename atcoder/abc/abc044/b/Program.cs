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
            string w = Console.ReadLine();
            int[] cnt = new int[26];
            for (int i = 0; i < w.Length; i++)
            {
                cnt[w[i] - 'a']++;
            }
            for (int i = 0; i < cnt.Length; i++)
            {
                if(cnt[i]%2>0)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
