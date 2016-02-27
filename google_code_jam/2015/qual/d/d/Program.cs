using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-small-2.txt"))
            {
                using (StreamReader r = new StreamReader(@"D-small-attempt2.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] xbc = r.ReadLine().Split(' ');
                        int x = int.Parse(xbc[0]);
                        int b = int.Parse(xbc[1]);
                        int c = int.Parse(xbc[2]);
                        if (b < c)
                        {
                            int tmp = b;
                            b = c;
                            c = tmp;                            
                        }
                        string ans = "";
                        if ((b * c) % x != 0)
                        {
                            ans = A(false);
                        }
                        else if (x < b)
                        {
                            ans = A(false);
                        }
                        else if (c < (x + 1) / 2)
                        {
                            ans = A(false);
                        }
                        else if (x <= 3)
                        {
                            ans = A(true);
                        }
                        else if (x == 4)
                        {
                            if (c < 3) ans = A(false);
                            else ans = A(true);
                        }
                        else if (x == 5)
                        {
                            if (c < 4) ans = A(false);
                            else ans = A(true);
                        }
                        else if (x == 6)
                        {
                            if (c < 3) ans = A(false);
                            else ans = A(true);
                        }
                        else if (x >= 7)
                        {
                            ans = A(false);
                        }
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }

        static string A(bool tf)
        {
            if (tf == true) return "GABRIEL";
            else return "RICHARD";
        }
    }
}
