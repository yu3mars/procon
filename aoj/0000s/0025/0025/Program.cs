using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0025
{
    class Program
    {
        static void Main(string[] args)
        {
            int hit,blow;
            while (true)
            {
                try
                {
                    hit = 0;
                    blow = 0;
                    string[] stra = Console.ReadLine().Split(' ');
                    string[] strb = Console.ReadLine().Split(' ');
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (stra[i] == strb[j])
                            {
                                if (i == j)
                                {
                                    hit += 1;
                                }
                                else
                                {
                                    blow += 1;
                                }
                            }
                        }                        
                    }
                    Console.WriteLine("{0} {1}", hit, blow);
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
