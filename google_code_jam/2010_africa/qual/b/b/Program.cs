using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"B-large-practice.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] s = r.ReadLine().Split(' ');
                        var s2 = s.Reverse();
                        var ans = string.Join(" ", s2);
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }           
        }
    }
}
