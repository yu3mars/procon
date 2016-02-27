using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] astr = Console.ReadLine().Split(' ');
            string[] bstr = Console.ReadLine().Split(' ');
            int c = int.Parse(Console.ReadLine());
            int[] a = new int[2];
            int[] b = new int[2];
            bool[] ab = new bool[2];
            for (int i = 0; i < 2; i++)
            {
                a[i] = int.Parse(astr[i]);
                b[i] = int.Parse(bstr[i]);
                if (a[i] == c) ab[0] = true;
                if (b[i] == c) ab[1] = true;
            }
            SortedSet<int> ls = new SortedSet<int>();
            if (ab[0])
            {
                for (int i = 0; i < 2; i++)
                {
                    ls.Add(b[i]);
                }
            }
            if (ab[1])
            {
                for (int i = 0; i < 2; i++)
                {
                    ls.Add(a[i]);
                }
            }
            Console.WriteLine(ls.Count);
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }

        }
    }
}
