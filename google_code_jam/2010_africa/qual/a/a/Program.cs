using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"A-large-practice.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        int c = int.Parse(r.ReadLine());
                        int icnt = int.Parse(r.ReadLine());
                        string[] pstr = r.ReadLine().Split(' ');
                        int[] pint = new int[icnt];
                        for (int j = 0; j < icnt; j++)
                        {
                            pint[j] = int.Parse(pstr[j]);
                        }
                        int[] ans = new int[2];
                        for (int j = 0; j < icnt; j++)
                        {
                            for (int k = j + 1; k < icnt; k++)
                            {
                                if (pint[j] + pint[k] == c)
                                {
                                    ans[0] = j + 1;
                                    ans[1] = k + 1;
                                }
                            }
                        }
                        w.WriteLine("Case #{0}: {1} {2}", i + 1, ans[0], ans[1]);
                    }
                }
            }
        }
    }
}
