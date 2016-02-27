using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] ls = new int[n];
            for (int i = 0; i < n; i++)
            {
                ls[i] = int.Parse(str[i]);
            }
            int[] dpa = new int[n + 2];
            int[] dpb = new int[n + 2];
            int cnta = 1;
            int cntb = 1;
            dpa[0] = int.MaxValue;
            dpb[0] = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = cnta; j > 0; j--)
                {
                    if (j % 2 == 0)
                    {
                        if (dpa[j - 1] < ls[i])
                        {
                            dpa[j] = ls[i];
                            if (j == cnta)
                            {
                                cnta += 1;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (dpa[j - 1] > ls[i])
                        {
                            dpa[j] = ls[i];
                            if (j == cnta)
                            {
                                cnta += 1;
                            }
                            break;
                        }
                    }
                }
                for (int j = cntb; j > 0; j--)
                {
                    if (j % 2 == 1)
                    {
                        if (dpb[j - 1] < ls[i])
                        {
                            dpb[j] = ls[i];
                            if (j == cntb)
                            {
                                cntb += 1;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (dpb[j - 1] > ls[i])
                        {
                            dpb[j] = ls[i];
                            if (j == cntb)
                            {
                                cntb += 1;
                            }
                            break;
                        }
                    }
                }
            }
            int ans = Math.Max(cnta, cntb) - 1;
            if (ans >= 3)
            {
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
