using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1179
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = getDate("1000 1 1");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int tar = getDate(Console.ReadLine());
                Console.WriteLine(end - tar);
            }
        }

        static int getDate(string date)
        {
            string[] str = date.Split(' ');
            int y = int.Parse(str[0]);
            int m = int.Parse(str[1]);
            int d = int.Parse(str[2]);
            int ans = 0;

            ans += (y - 1) * 195 + (y - 1) / 3 * 5;//year
            if (y % 3 == 0)//month
            {
                ans += (m - 1) * 20;
            }
            else
            {
                ans += (m - 1) * 20 - (m - 1) / 2;
            }
            ans += d;//day

            return ans;
        }
    }
}
