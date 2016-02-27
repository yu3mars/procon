using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2340
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            long cnt = 0;
            for (int i = 0; i < q; i++)
            {
                string[] pcn = Console.ReadLine().Split(' ');
                int n = int.Parse(pcn[2]);
                if (pcn[1] == "(") cnt += n;
                else cnt -= n;
                if (cnt == 0) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }
    }
}
