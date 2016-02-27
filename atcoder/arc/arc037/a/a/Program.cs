using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] mstr = Console.ReadLine().Split(' ');
            int[] m = new int[n];
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                m[i] = Math.Max(0, 80 - int.Parse(mstr[i]));
                ans += m[i];
            }
            Console.WriteLine(ans);
        }
    }
}
