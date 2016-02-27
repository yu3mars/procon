using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1275
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nkm = Console.ReadLine().Split(' ');
                int n = int.Parse(nkm[0]);
                int k = int.Parse(nkm[1]);
                int m = int.Parse(nkm[2]);
                if (n == 0 && k == 0 & m == 0) return;
                List<int> ls = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    ls.Add(i + 1);
                }
                int now = m - 1;
                while (ls.Count > 1)
                {
                    ls.Remove(ls[now]);
                    now = (now + k - 1) % ls.Count;
                }
                Console.WriteLine(ls[0]);
            }
        }
    }
}
