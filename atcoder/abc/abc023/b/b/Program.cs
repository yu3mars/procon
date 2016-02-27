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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            bool ng = false;
            if (n % 2 == 0)
            {
                Console.WriteLine(-1);
                return;
            }
            int center = n / 2;
            char[] ls = new char[]{ 'a', 'b', 'c' };
            for (int i = 0; i <= center; i++)
            {
                if (s[center + i] != ls[(i + 1) % 3])
                {
                    ng = true;
                    break;
                }
                if (s[center - i] != ls[2 - (i + 1) % 3])
                {
                    ng = true;
                    break;
                }
            }
            if (ng == true)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(center);
            }
        }
    }
}
