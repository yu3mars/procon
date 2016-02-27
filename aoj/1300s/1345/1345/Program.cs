using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1345
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            string[] bstr = Console.ReadLine().Split(' ');
            string[] pstr = Console.ReadLine().Split(' ');
            string b = "";
            int[] p = new int[m];
            string pzero = "";
            string pone = "";
            int zerocnt = 0;
            int onecnt = 0;
            int oddcnt = 0;
            int evencnt = 0;
            int ans = int.MaxValue;
            
            for (int i = 0; i < n; i++)
            {
                b += bstr[i];
                if (bstr[i] == "0") zerocnt++;
                else onecnt++;
            }
            for (int i = 0; i < m; i++)
            {
                p[i] = int.Parse(pstr[i]);
                if (i % 2 == 0)
                {
                    evencnt += p[i];
                    for (int j = 0; j < p[i]; j++)
                    {
                        pzero += "0";
                        pone += "1";
                    }
                }
                else
                {
                    oddcnt += p[i];
                    for (int j = 0; j < p[i]; j++)
                    {
                        pzero += "1";
                        pone += "0";
                    }
                }
            }
            if (evencnt < oddcnt)
            {
                string tmpstr = pzero;
                pzero = pone;
                pone = tmpstr;
            }

            if (zerocnt >= onecnt)
            {
                int[] zerobef = new int[zerocnt];
                int[] zeroaft = new int[zerocnt];
                int zbcnt = 0;
                int zacnt = 0;
                for (int i = 0; i < n; i++)
                {
                    if (b[i] == '0')
                    {
                        zerobef[zbcnt] = i;
                        zbcnt++;
                    }
                    if (pzero[i] == '0')
                    {
                        zeroaft[zacnt] = i;
                        zacnt++;
                    }
                }
                int tmp = 0;
                for (int i = 0; i < zerocnt; i++)
                {
                    tmp += Math.Abs(zerobef[i] - zeroaft[i]);
                }
                ans = Math.Min(ans, tmp);
            }
            if (zerocnt <= onecnt)
            {
                int[] zerobef = new int[zerocnt];
                int[] zeroaft = new int[zerocnt];
                int zbcnt = 0;
                int zacnt = 0;
                for (int i = 0; i < n; i++)
                {
                    if (b[i] == '0')
                    {
                        zerobef[zbcnt] = i;
                        zbcnt++;
                    }
                    if (pone[i] == '0')
                    {
                        zeroaft[zacnt] = i;
                        zacnt++;
                    }
                }
                int tmp = 0;
                for (int i = 0; i < zerocnt; i++)
                {
                    tmp += Math.Abs(zerobef[i] - zeroaft[i]);
                }
                ans = Math.Min(ans, tmp);
            }
            Console.WriteLine(ans);            
        }
    }
}
