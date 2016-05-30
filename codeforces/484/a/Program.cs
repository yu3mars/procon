using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[] lr = Console.ReadLine().Split().Select(long.Parse).ToArray();
                string l = Convert.ToString(lr[0], 2).PadLeft(60, '0');
                string r = Convert.ToString(lr[1], 2).PadLeft(60, '0');
                StringBuilder sb = new StringBuilder();
                int same = 100;
                for (int j = 0; j < l.Length; j++)
                {
                    if (j < same)
                    {
                        if (l[j] == r[j]) sb.Append(l[j]);
                        else
                        {
                            sb.Append('0');
                            same = j;
                        }
                    }
                    else sb.Append("1");
                }
                long tmp = Convert.ToInt64(sb.ToString(), 2);
                if (tmp < lr[0] || bitCount(tmp) < bitCount(lr[1])) tmp = lr[1];
                Console.WriteLine(tmp);
            }
        }
        static int bitCount(long x)
        {
            x = (x & 0x5555555555555555) + (x >> 1 & 0x5555555555555555);
            x = (x & 0x3333333333333333) + (x >> 2 & 0x3333333333333333);
            x = (x & 0x0f0f0f0f0f0f0f0f) + (x >> 4 & 0x0f0f0f0f0f0f0f0f);
            x = (x & 0x00ff00ff00ff00ff) + (x >> 8 & 0x00ff00ff00ff00ff);
            x = (x & 0x0000ffff0000ffff) + (x >> 16 & 0x0000ffff0000ffff);
            return (int)((x & 0x00000000ffffffff) + (x >> 32 & 0x00000000ffffffff));
        }


    }
}
