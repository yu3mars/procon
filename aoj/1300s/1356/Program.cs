using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1356
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ls = new string[n];
            int cnt = 0;
            while(cnt<n)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int i = 0; i < s.Length; i++)
                {
                    ls[cnt] = s[i];
                    cnt++;
                }
            }
            string d = String.Join("", ls);
            HashSet<string> set = new HashSet<string>();
            for (int len = 1; len < n; len++)
            {
                for (int bgn = 0; bgn < n - len + 1; bgn++)
                {
                    string sub = d.Substring(bgn, len);
                    set.Add(sub);
                }
            }
            for (int i = 0; ; i++)
            {
                if(set.Contains(i.ToString()) == false)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
