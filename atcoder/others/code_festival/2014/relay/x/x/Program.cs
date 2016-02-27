using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int xsum = 0;
            int ysum = 0;
            for (int i = 0; i < n; i++)
            {
                char[] chr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    string target = chr[j].ToString();
                    if (target == "X")
                    {
                        xsum += i;
                    }
                    else if (target == "Y")
                    {
                        ysum += (n - 1 - i);
                    }
                }
            }
            if (xsum > ysum)
            {
                Console.WriteLine("X");
            }
            else if (xsum < ysum)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}
