using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tk = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                foreach (char c in s)
                {
                    if (c == 'R') tk++;
                    else if (c == 'B') tk--;
                }
            }
            if (tk > 0) Console.WriteLine("TAKAHASHI");
            else if (tk < 0) Console.WriteLine("AOKI");
            else Console.WriteLine("DRAW");
        }
    }
}
