using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0538
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }
                int len = int.Parse(Console.ReadLine());
                char[] chr = Console.ReadLine().ToCharArray();
                bool checkflag = false;
                bool ichecked = false;
                int cnt = 0;
                int ans = 0;
                for (int i = 0; i < len; i++)
                {
                    string target = chr[i].ToString();
                    if (checkflag == true)
                    {
                        if (ichecked == true)//o nara yoi
                        {
                            if (target == "I")
                            {
                                checkflag = true;
                                ichecked = true;
                                cnt = 0;
                            }
                            else
                            {
                                ichecked = false;
                            }
                        }
                        else//i nara yoi
                        {
                            if (target == "I")
                            {
                                ichecked = true;
                                cnt += 1;
                                if (cnt >= n)
                                {
                                    ans += 1;
                                }
                            }
                            else
                            {
                                checkflag = false;
                            }
                        }
                    }
                    else//check not started
                    {
                        if (target == "I")
                        {
                            checkflag = true;
                            ichecked = true;
                            cnt = 0;
                        }
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
