using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10015
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] s = new bool[14];
            bool[] h = new bool[14];
            bool[] c = new bool[14];
            bool[] d = new bool[14];
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                switch (str[0])
                {
                    case "S":
                        s[int.Parse(str[1])] = true;
                        break;
                    case "H":
                        h[int.Parse(str[1])] = true;
                        break;
                    case "C":
                        c[int.Parse(str[1])] = true;
                        break;
                    case "D":
                        d[int.Parse(str[1])] = true;
                        break;
                }
            }
            for (int i = 1; i < 14; i++)
            {
                if (s[i] == false)
                {
                    Console.WriteLine("S " + i);
                }
            }
            for (int i = 1; i < 14; i++)
            {
                if (h[i] == false)
                {
                    Console.WriteLine("H " + i);
                }
            }
            for (int i = 1; i < 14; i++)
            {
                if (c[i] == false)
                {
                    Console.WriteLine("C " + i);
                }
            }
            for (int i = 1; i < 14; i++)
            {
                if (d[i] == false)
                {
                    Console.WriteLine("D " + i);
                }
            }
        }
    }
}
