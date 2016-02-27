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
            string[] str = Console.ReadLine().Split(' ');
            int x = int.Parse(str[0]);
            int y = int.Parse(str[1]);
            int min = Math.Min(x, y);
            int ans = min % 2;
            if (ans == 1)
            {
                Console.WriteLine("Akshat");
            }
            else
            {
                Console.WriteLine("Malvika");
            }
        }
    }
}
