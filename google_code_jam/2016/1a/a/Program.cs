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
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"A-large.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string s = r.ReadLine();
                        string ans = s[0].ToString();

                        for (int j = 1; j < s.Length; j++)
                        {
                            if(s[j]<ans[0])
                            {
                                ans = ans + s[j];
                            }
                            else
                            {
                                ans = s[j] + ans;
                            }
                                
                        }

                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
