using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace f
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = new int[7];
            for (int i = 0; i < 7; i++)
            {
                n[i] = int.Parse(s[i]);
            }
        }
    }
}
