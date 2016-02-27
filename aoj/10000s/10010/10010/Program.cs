using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10010
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[1] == "+")
                {
                    ans = int.Parse(str[0]) + int.Parse(str[2]);
                    Console.WriteLine(ans);
                }
                else if (str[1] == "-")
                {
                    ans = int.Parse(str[0]) - int.Parse(str[2]);
                    Console.WriteLine(ans);
                }
                else if (str[1] == "*")
                {
                    ans = int.Parse(str[0]) * int.Parse(str[2]);
                    Console.WriteLine(ans);
                }
                else if (str[1] == "/")
                {
                    ans = int.Parse(str[0]) / int.Parse(str[2]);
                    Console.WriteLine(ans);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
