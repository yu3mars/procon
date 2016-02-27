using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2582
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
                string[] str = Console.ReadLine().Split(' ');
                bool lup = false;
                bool rup = false;
                bool bup = false;
                int cnt = 0;
                for (int i = 0; i < n; i++)
                {
                    string next = str[i];
                    if (next == "lu")
                    {
                        lup = true;
                    }
                    else if (next == "ld")
                    {
                        lup = false;
                    }
                    else if (next == "ru")
                    {
                        rup = true;
                    }
                    else if (next == "rd")
                    {
                        rup = false;
                    }

                    if (bup == false && lup == true && rup == true)
                    {
                        cnt += 1;
                        bup = true;
                    }
                    else if (bup == true && lup == false && rup == false)
                    {
                        cnt += 1;
                        bup = false;
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
