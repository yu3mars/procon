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
            int ans = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                ans += int.Parse(str[0]) * int.Parse(str[1]) / 10;
            }
            Console.WriteLine(ans);
        }
    }
}
