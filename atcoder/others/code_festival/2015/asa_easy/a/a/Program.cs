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
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < 101; i++)
            {
                if (n <= i * i)
                {
                    ans = i * i - n;
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
