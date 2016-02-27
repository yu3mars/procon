using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0506
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
                string str = Console.ReadLine();
                for (int ncount = 0; ncount < n; ncount++)
                {
                    if (str.Length == 1)
                    {
                        str = "1" + str;
                    }
                    else
                    {
                        int cnt = 1;
                        string nextstr = ""; 
                        char[] chr = str.ToCharArray();
                        for (int i = 0; i < str.Length-1; i++)
                        {
                            if (chr[i] == chr[i + 1])
                            {
                                cnt += 1;
                            }
                            else
                            {
                                nextstr = nextstr + cnt.ToString() + chr[i].ToString();
                                cnt = 1;
                            }
                        }
                        nextstr = nextstr + cnt.ToString() + chr[str.Length-1].ToString();
                        str = nextstr;
                    }
                }
                Console.WriteLine(str);
            }
        }
    }
}
