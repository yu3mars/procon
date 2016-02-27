using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10011
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            for (int i = total; i >0; i--)
            {
                Console.Write(str[i-1]);
                if (i > 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
