using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2440
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> reg = new HashSet<string>();
            for(int i=0;i<n;i++)
            {
                reg.Add(Console.ReadLine());
            }
            int m = int.Parse(Console.ReadLine());
            bool open = false;
            for (int i = 0; i < m; i++)
            {
                string user = Console.ReadLine();
                if (reg.Contains(user) == true)
                {
                    if (open == false)
                    {
                        open = true;
                        Console.WriteLine("Opened by {0}", user);
                    }
                    else
                    {
                        open = false;
                        Console.WriteLine("Closed by {0}", user);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown {0}", user);
                }
            }
        }
    }
}
