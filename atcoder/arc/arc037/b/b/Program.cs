using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static int[] uni;
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            uni = new int[n];
            for (int i = 0; i < uni.Length; i++)
            {
                uni[i] = -1;
            }
            SortedSet<int> tree = new SortedSet<int>();
            SortedSet<int> notree = new SortedSet<int>();            
            for (int i = 0; i < m; i++)
            {
                string[] uv = Console.ReadLine().Split(' ');
                int u = (int.Parse(uv[0])) - 1;
                int v = (int.Parse(uv[1])) - 1;
                if (IsConnect(u, v) == true)
                {
                    notree.Add(Root(u));
                }
                Connect(u, v);
            }
            for (int i = 0; i < n; i++)
            {
                if (notree.Contains(Root(i)) == false)
                {
                    tree.Add(Root(i));
                }
            }
            Console.WriteLine(tree.Count);
        }

        static int Root(int a)
        {
            if (uni[a] < 0)
            {
                return a;
            }
            else
            {
                return uni[a] = Root(uni[a]);
            }
        }

        static void Connect(int a, int b)
        {
            int ra = Root(a);
            int rb = Root(b);
            if (ra == rb)
            {
                return;
            }
            if (uni[ra] > uni[rb])
            {
                uni[ra] = rb;
            }
            else
            {
                if (uni[ra] == uni[rb])
                {
                    uni[ra] -= 1;
                }
                uni[rb] = ra;
            }
        }

        static bool IsConnect(int a, int b)
        {
            return Root(a) == Root(b);
        }
    }
}
