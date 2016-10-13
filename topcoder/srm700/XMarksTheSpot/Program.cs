using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMarksTheSpot_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
class XMarksTheSpot
{
    public static int countArea(string[] s)
    {
        int ans = 0;
        int question = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s[0].Length; j++)
            {
                if(s[i][j]=='?')
                {
                    question++;
                }
            }
        }
        for (int bitcnt = 0; bitcnt < (1<<question); bitcnt++)
        {
            int qcnt = 0;
            int l = int.MaxValue;
            int r = int.MinValue;
            int u = int.MaxValue;
            int d = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s[0].Length; j++)
                {
                    if(s[i][j]=='O')
                    {
                        l = Math.Min(l, j);
                        r = Math.Max(r, j);
                        u = Math.Min(u, i);
                        d = Math.Max(d, i);
                    }
                    else if(s[i][j]=='?')
                    {
                        if (((bitcnt >> qcnt) & 1) == 1)
                        {
                            l = Math.Min(l, j);
                            r = Math.Max(r, j);
                            u = Math.Min(u, i);
                            d = Math.Max(d, i);
                        }
                        qcnt++;
                    }
                }
            }
            ans += (r - l + 1) * (d - u + 1);
        }
        return ans;
    }
}
