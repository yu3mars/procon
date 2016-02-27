using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0003
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                int[] abc = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    abc[j] = int.Parse(str[j]);
                }
                Array.Sort(abc);
                if (abc[0] * abc[0] + abc[1] * abc[1] == abc[2] * abc[2])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
