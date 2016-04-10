using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter w = new StreamWriter(@"output-small.txt"))
            {
                using (StreamReader r = new StreamReader(@"C-small.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] nj = r.ReadLine().Split(' ');
                        int len = int.Parse(nj[0]);
                        int cnt = int.Parse(nj[1]);

                        int max = (int)Math.Pow(2, len);

                        bool[] isprime = new bool[Int64.MaxValue];
                        for (int p = 0; p < isprime.Length; p++)
                        {
                            isprime[p] = true;
                        }
                        isprime[0] = false;
                        isprime[1] = false;
                        for (int p = 2; p < isprime.Length; p++)
                        {
                            if (isprime[p] == true)
                            {
                                for (int q = p * 2; q < isprime.Length; q += p)
                                {
                                    isprime[q] = false;
                                }
                            }
                        }

                        w.WriteLine("Case #{0}:", i + 1);
                        int jcnt = 0;
                        for (int j = 0; j < max; j++)
                        {
                            string tar = Convert.ToString(j, 2).PadLeft(len,'0');
                            if (tar[0] == '0' || tar[tar.Length - 1] == '0') continue;
                            else
                            {
                                string tmp = tar;
                                bool includePrime = true;
                                for (int k = 2; k < 11; k++)
                                {
                                    int based = conv(tar, k);
                                    if (isprime[based])
                                    {
                                        includePrime = false;
                                        break;
                                    }
                                    int basedans = based;
                                    for (int l = 2; l < based; l++)
                                    {
                                        if (based % l == 0)
                                        {
                                            basedans = based / l;
                                            break;
                                        }
                                    }
                                    tmp += " " + basedans;
                                }
                                if (includePrime)
                                {
                                    w.WriteLine(tmp);
                                    jcnt++;
                                    if (jcnt == cnt) break;
                                }
                            }
                        }
                        
                        //w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }

        static int conv(string numstr, int baseint)
        {
            int ret = 0;
            int tmp = 1;
            for (int i = numstr.Length - 1; i >= 0; i--)
            {
                if (numstr[i] == '1')
                {
                    ret += tmp;
                }
                tmp *= baseint;
            }
            return ret;
        }
    }
}
