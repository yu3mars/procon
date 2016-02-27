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
            string[] astr = Console.ReadLine().Split(' ');
            int bug = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int tar = int.Parse(astr[i]);
                if (tar != 0)
                {
                    bug += tar;
                    sum += 1;
                }
            }
            if (bug % sum == 0)
            {
                Console.WriteLine(bug / sum);
            }
            else
            {
                Console.WriteLine(bug / sum + 1);

            }
        }
    }
}
