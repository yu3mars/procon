using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-sample.txt"))
            {
                using (StreamReader r = new StreamReader(@"C-sample-practice.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string s = Console.ReadLine();
                        w.Write("Case #{0}: ", i + 1);
                        int now = -1;
                        for (int j = 0; j < s.Length; j++)
                        {
                            char c = s[j];
                            if (c == ' ')
                            {
                                if (now == 0) w.Write(" ");
                                w.Write(0);
                                now = 0;
                            }
                            else if (c == 'a')
                            {
                                if (now == 2) w.Write(" ");
                                w.Write(2);
                                now = 2;
                            }
                            else if (c == 'b')
                            {
                                if (now == 2) w.Write(" ");
                                w.Write(22);
                                now = 2;
                            }
                            else if (c == 'c')
                            {
                                if (now == 2) w.Write(" ");
                                w.Write(222);
                                now = 2;
                            }
                        }
                        w.WriteLine();
                        //w.WriteLine("Case #{0}: {1} {2}", i + 1, ans[0], ans[1]);
                    }
                }
            }
        }
    }
}
