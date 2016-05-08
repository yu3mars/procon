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
            using (StreamWriter w = new StreamWriter(@"output-sample.txt"))
            {
                using (StreamReader r = new StreamReader(@"B-sample.in"))
                {
                    int n = int.Parse(r.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] s = r.ReadLine().Split(' ');
                        string[] ans = new string[2] { "", "" };
                        int same = 0;
                        for (int j = 0; j < s[0].Length; j++)
                        {
                            if(same==0)//sayuu onaji
                            {
                                if(s[0][j] ==s[1][j])
                                {
                                    if(s[0][j]=='?')
                                    {
                                        ans[0] += "0";
                                        ans[1] += "0";
                                    }
                                    else
                                    {
                                        ans[0] += s[0][j];
                                        ans[1] += s[0][j];
                                    }
                                }
                                else if (s[0][j] == '?')
                                {

                                    ans[0] += s[1][j];
                                    ans[1] += s[1][j];
                                }
                                else if (s[1][j] == '?')
                                {

                                    ans[0] += s[0][j];
                                    ans[1] += s[0][j];
                                }
                                else
                                {
                                    if(s[0][j] > s[1][j])
                                    {
                                        same = 1;
                                        ans[0] += s[0][j];
                                        ans[1] += s[1][j];
                                    }
                                    else
                                    {
                                        same = -1;
                                        ans[0] += s[0][j];
                                        ans[1] += s[1][j];
                                    }
                                }
                            }
                            else if(same>0) //hidari ookii
                            {

                            }
                            else if (same < 0) //migi ookii
                            {

                            }
                        }

                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
