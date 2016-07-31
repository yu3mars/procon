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
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string namestr = Console.ReadLine();
            string kitstr = Console.ReadLine();
            int[] name = new int[26];
            int[] kit = new int[26];
            for (int i = 0; i < namestr.Length; i++)
            {
                name[namestr[i] - 'A']++;
            }
            for (int i = 0; i < kitstr.Length; i++)
            {
                kit[kitstr[i]-'A']++;
            }
            int ans = 0;
            for (int i = 0; i < 26; i++)
            {
                if (name[i] == 0) continue;
                if(kit[i]==0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                else
                {
                    int cnt = name[i] / kit[i];
                    if (name[i] % kit[i] > 0) cnt++;
                    ans = Math.Max(ans, cnt);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
