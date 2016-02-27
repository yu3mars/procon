using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10023
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string str = Console.ReadLine();
                if (str == "-")
                {
                    return;
                }
                int m = int.Parse(Console.ReadLine());
                for (int i = 0; i < m; i++)
                {
                    int h = int.Parse(Console.ReadLine());
                    string mae = str.Substring(0, h);
                    string ushiro = str.Substring(h);
                    str = ushiro + mae;
                }
                Console.WriteLine(str);
            }
        }
    }
}
