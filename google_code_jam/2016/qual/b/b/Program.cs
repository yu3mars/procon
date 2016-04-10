using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"B-large.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string s = r.ReadLine();
                        int cnt = 0;
                        
                        for (int j = 0; j < s.Length - 1; j++)
                        {
                            if (s[j] != s[j + 1]) cnt++;
                        }
                        if (s[s.Length - 1] == '-') cnt++;

                        int ans = cnt;
                        
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
