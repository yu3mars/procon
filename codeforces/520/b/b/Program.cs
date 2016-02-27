using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int from = int.Parse(str[0]);
            int to = int.Parse(str[1]);
            int cnt = 0;
            while (from != to)
            {
                if (from > to)
                {
                    to += 1;
                }
                else if (to % 2 != 0)
                {
                    to += 1;
                }
                else
                {
                    to /= 2;
                }
                cnt += 1;
            }
            Console.WriteLine(cnt);
        }
    }
}
