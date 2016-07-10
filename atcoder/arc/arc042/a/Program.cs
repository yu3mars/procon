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
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            bool[] b = new bool[n + 1];
            List<int> ls = new List<int>();
            for (int i = n; i > 0; i--)
            {
                ls.Add(i);
            }
            for (int i = 0; i < m; i++)
            {
                ls.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = ls.Count - 1; i >= 0; i--)
            {
                if(b[ls[i]]==false)
                {
                    b[ls[i]] = true;
                    Console.WriteLine(ls[i]);
                }
            }

        }
    }
}
