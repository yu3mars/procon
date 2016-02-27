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
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            List<List<int>> ls = new List<List<int>>();
            for (int i = 0; i <= n; i++)
            {
                ls.Add(new List<int>());
            }

            for (int i = 0; i < m; i++)
            {
                string[] ab = Console.ReadLine().Split(' ');
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                ls[b].Add(a);
            }
            
            SortedSet<int> upper = new SortedSet<int>();
            upper.Add(1);

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            while (q.Count > 0)
            {
                int now = q.Dequeue();
                foreach (int next in ls[now])
                {
                    upper.Add(next);
                    q.Enqueue(next);
                }
            }
            Console.WriteLine(upper.Count);
        }

    }
}
