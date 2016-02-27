using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0587
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int max = s;
            bool error = false;
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                s = s + int.Parse(str[0]) - int.Parse(str[1]);
                if (s < 0)
                {
                    error = true;
                }
                max = Math.Max(max, s);
            }
            if (error == true)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(max);
            }
        }
    }
}
