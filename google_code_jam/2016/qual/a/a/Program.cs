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
                using (StreamReader r = new StreamReader(@"A-large.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        long t = long.Parse(r.ReadLine());
                        string ans = "";
                        if (t == 0) ans = "INSOMNIA";
                        else
                        {
                            SortedSet<char> set = new SortedSet<char>();
                            for (long j = 1; j < 100000; j++)
                            {
                                string tmp = (t * j).ToString();
                                for (int k = 0; k < tmp.Length; k++)
                                {
                                    set.Add(tmp[k]);
                                }
                                if (set.Count == 10)
                                {
                                    ans = tmp;
                                    break;
                                }
                            }
                        }
                        
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
