using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorruptedMessage
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class CorruptedMessage
    {
        public static string reconstructMessage(string s, int k)
        {
            int len = s.Length;
            int same = len - k;
            char chr = 'a';
            int[] cnt = new int[26];
            for (int i = 0; i < len; i++)
            {
                cnt[s[i] - 'a'] += 1;
            }
            for (int i = 0; i < 26; i++)
            {
                if (cnt[i] == same)
                {
                    chr = (char)((int)'a' + i);
                    break;
                }
            }
            string ans = "";
            for (int i = 0; i < len; i++)
            {
                ans += chr.ToString();
            }
            return ans;
        }
    }
}
