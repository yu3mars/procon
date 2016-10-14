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
        List<int> qx = new List<int>();
        List<int> qy = new List<int>();
        int l = int.MaxValue;
        int r = int.MinValue;
        int u = int.MaxValue;
        int d = int.MinValue;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s[0].Length; j++)
            {
                if(s[i][j]=='?')
                {
                    qx.Add(i);
                    qy.Add(j);
                }
                else if (s[i][j] == 'O')
                {
                    l = Math.Min(l, j);
                    r = Math.Max(r, j);
                    u = Math.Min(u, i);
                    d = Math.Max(d, i);
                }
            }
        }

        for (int bitcnt = 0; bitcnt < (1<<qx.Count); bitcnt++)
        {
            int ltmp = l;
            int rtmp = r;
            int utmp = u;
            int dtmp = d;
            for (int qcnt = 0; qcnt < qx.Count; qcnt++)
            {
                if (((bitcnt >> qcnt) & 1) == 1)
                {
                    ltmp = Math.Min(ltmp, qy[qcnt]);
                    rtmp = Math.Max(rtmp, qy[qcnt]);
                    utmp = Math.Min(utmp, qx[qcnt]);
                    dtmp = Math.Max(dtmp, qx[qcnt]);
                }
            }
            
            ans += (rtmp - ltmp + 1) * (dtmp - utmp + 1);
        }
        return ans;
    }
}
