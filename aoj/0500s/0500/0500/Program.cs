using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0500
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,a,b,suma,sumb;
            for (; ; )
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
                else
                {
                    suma = 0;
                    sumb = 0;
                    for (int i = 0; i < num; i++)
                    {
                        string[] str = Console.ReadLine().Split(' ');
                        a = int.Parse(str[0]);
                        b = int.Parse(str[1]);
                        if (a > b)
                        {
                            suma = suma + a + b;
                        }
                        else if (a < b)
                        {
                            sumb = sumb + a + b;
                        }
                        else
                        {
                            suma += a;
                            sumb += b;
                        }
                    }
                    Console.WriteLine("{0} {1}", suma, sumb);
                }
            }
        }
    }
}
