﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ans += Math.Abs(i-x);
            }
            ans = ans / 2;
            Console.WriteLine(ans);
        }
    }
}
