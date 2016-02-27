using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[3];
            int[] srt = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int now = int.Parse(Console.ReadLine());
                n[i] = now;
                srt[i] = now;
            }
            Array.Sort(srt);
            Array.Reverse(srt);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (n[i] == srt[j])
                    {
                        Console.WriteLine(j + 1);
                    }
                }
            }

        }
    }
}
