using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10016
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] str = Console.ReadLine().Split(' ');
                int[] p = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    p[i] = int.Parse(str[i]);
                }
                int s = p[0] + p[1];
                if (p[0] == -1 && p[1] == -1 && p[2] == -1)
                {
                    return;
                }
                else if(p[0] ==-1 || p[1]==-1 || s <30)
                {
                    Console.WriteLine("F");
                }
                else if (s < 50)
                {
                    if (p[2] < 50)
                    {
                        Console.WriteLine("D");
                    }
                    else
                    {
                        Console.WriteLine("C");
                    }
                }
                else if (s < 65)
                {
                    Console.WriteLine("C");
                }
                else if (s < 80)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    Console.WriteLine("A");
                }
            }
        }
    }
}
