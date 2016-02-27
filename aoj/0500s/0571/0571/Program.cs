using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0571
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int jcnt = 0;
            int ocnt = 0;
            int icnt = 0;
            int ans = 0;
            int status = 3;//0,1,2,3=j,o,i,err

            for (int p = 0; p < s.Length; p++)
            {
                string now = s[p].ToString();
                if (now == "J")
                {
                    if (status == 0)
                    {
                        jcnt += 1;
                    }
                    else
                    {
                        if (status == 2 && jcnt >= ocnt && ocnt <= icnt)
                        {
                            ans = Math.Max(ans, ocnt);
                        }
                        jcnt = 1;
                        ocnt = 0;
                        icnt = 0;
                        status = 0;
                    }
                }
                else if (now == "O")
                {
                    if (status == 0)
                    {
                        status = 1;
                        ocnt += 1;
                    }
                    else if (status == 1)
                    {
                        ocnt += 1;
                    }
                    else
                    {
                        if (status == 2 && jcnt >= ocnt && ocnt <= icnt)
                        {
                            ans = Math.Max(ans, ocnt);
                        }
                        status = 3;
                    }
                }
                else if (now == "I")
                {
                    if (status == 1)
                    {
                        status = 2;
                        icnt += 1;
                    }
                    else if (status == 2)
                    {
                        icnt += 1;
                    }
                    else
                    {
                        status = 3;
                    }
                }
            }
            if (status == 2 && jcnt >= ocnt && ocnt <= icnt)
            {
                ans = Math.Max(ans, ocnt);
            }
            Console.WriteLine(ans);
        }
    }
}
