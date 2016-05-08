using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace a
{
    class Program
    {
        static string s,ans;
        static string[] words;
        static int[] cnt;
        static Dictionary<char, int> dic;
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"A-large.in"))
                {
                    words = new string[10] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        s = r.ReadLine();
                        dic = new Dictionary<char, int>();
                        ans = "";
                        cnt = new int[10];

                        for (int j = 0; j < 26; j++)
                        {
                            char c = (char)('A' + j);
                            dic.Add(c, 0);
                        }
                        for (int j = 0; j < s.Length; j++)
                        {
                            dic[s[j]]++;
                        }

                        cnt[0] += check(words[0], 'Z');
                        cnt[2] += check(words[2], 'W');
                        cnt[6] += check(words[6], 'X');
                        cnt[8] += check(words[8], 'G');
                        cnt[4] += check(words[4], 'U');

                        cnt[5] += check(words[5], 'F');
                        cnt[7] += check(words[7], 'V');

                        cnt[1] += check(words[1], 'O');
                        cnt[3] += check(words[3], 'R');
                        cnt[9] += check(words[9], 'I');

                        for (int j = 0; j < 10; j++)
                        {
                            for (int k = 0; k < cnt[j]; k++)
                            {
                                ans += j.ToString();
                            }
                        }
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }

        static int check(string str,char chr)
        {
            int count = dic[chr];
            for (int i = 0; i < str.Length; i++)
            {
                dic[str[i]] -= count;
            }
            return count;
        }
    }
}
