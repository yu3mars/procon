using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] col = new int[n];
            for (int i = 0; i < n; i++)
            {
                col[i] = int.Parse(Console.ReadLine());
            }
            List<int> ls = new List<int>();
            int cnt = 1;
            int now = col[0];
            for (int i = 0; i < n - 1; i++)
            {
                if(col[i]!=col[i+1])
                {
                    ls.Add(cnt);
                    cnt = 0;
                }
                cnt++;
            }
            ls.Add(cnt);
            if(ls.Count<2)
            {
                Console.WriteLine(-1);
                return;
            }

            if (col[0]==col[n-1])
            {
                ls.Add(ls[0] + ls.Last());
            }
            Console.WriteLine((ls.Max() - 1) / 2 + 1);
        }
    }
}
