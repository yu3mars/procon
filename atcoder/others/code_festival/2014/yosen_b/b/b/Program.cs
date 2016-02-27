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
            int n = int.Parse(str[0]);
            int k = int.Parse(str[1]);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += int.Parse(Console.ReadLine());
                if (sum >= k)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
