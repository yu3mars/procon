using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                set.Add(a[i]);
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int cnt = 0;
            foreach (int i in set)
            {
                dic.Add(i, cnt);
                cnt++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dic[a[i]]);
            }
        }
    }
}
