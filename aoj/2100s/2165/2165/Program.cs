using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2165
{
    class Program
    {
        static int[, , ,] r;//s,a,c,i
        static void Main(string[] args)
        {
            r = new int[16, 16, 16, 260];
            SetR();
            
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;

                string[] lstr = Console.ReadLine().Split(' ');
                int[] l = new int[n];
                for (int j = 0; j < n; j++)
                {
                    l[j] = int.Parse(lstr[j]);
                }
                int[] sac = new int[3];
                double h = double.MaxValue;
                
                for (int s = 0; s < 16; s++)
                {
                    for (int a = 0; a < 16; a++)
                    {
                        for (int c = 0; c < 16; c++)
                        {
                            double htmp = 0;
                            SortedDictionary<int, int> o 
                                = new SortedDictionary<int, int>();
                            for (int i = 0; i < n; i++)
                            {
                                int otmp = (l[i] + r[s, a, c, i + 1]) % 256;
                                if (o.ContainsKey(otmp))
                                {
                                    o[otmp] += 1;
                                }
                                else
                                {
                                    o.Add(otmp, 1);
                                }
                            }

                            int[] ols = new int[o.Values.Count];
                            o.Values.CopyTo(ols, 0);
                            for (int j = 0; j < ols.Length; j++)
                            {
                                htmp -= (double)ols[j] / n * Math.Log((double)ols[j] / n);
                            }

                            if (h > htmp + 1e-6)
                            {
                                h = htmp;
                                sac[0] = s;
                                sac[1] = a;
                                sac[2] = c;
                            }
                            //Console.WriteLine("{0} {1} {2} {3} {4}", s, a, c, htmp,h);//debug
                        }
                    }
                }
                Console.WriteLine("{0} {1} {2}", sac[0], sac[1], sac[2]);

            }
        }

        private static void SetR()
        {
            for (int s = 0; s < 16; s++)
            {
                for (int a = 0; a < 16; a++)
                {
                    for (int c = 0; c < 16; c++)
                    {
                        r[s, a, c, 0] = s;
                    }
                }
            }
            for (int s = 0; s < 16; s++)
            {
                for (int a = 0; a < 16; a++)
                {
                    for (int c = 0; c < 16; c++)
                    {
                        for (int i = 1; i < 260; i++)
                        {
                            r[s, a, c, i] =
                                (a * r[s, a, c, i - 1] + c) % 256;
                        }
                    }
                }
            }
        }
    }
}
