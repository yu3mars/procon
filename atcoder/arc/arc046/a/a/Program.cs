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
            int keta = n / 9;
            int num = n % 9;
            if (num == 0)
            {
                for (int i = 0; i < keta; i++)
                {
                    Console.Write(9);
                }
            }
            else
            {
                for (int i = 0; i <= keta; i++)
                {
                    Console.Write(num);
                }
            }
            Console.WriteLine();

        }
    }
}
