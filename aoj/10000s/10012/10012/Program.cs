using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10012
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int h = int.Parse(str[0]);
                int w = int.Parse(str[1]);
                if (h == 0 && w == 0)
                {
                    return;
                }
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
