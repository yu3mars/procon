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
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            int l = 0;
            HashSet<int> set = new HashSet<int>();
            for (int r = 0; r < n; r++)
            {
                while(set.Contains(a[r])==true)
                {
                    set.Remove(a[l]);
                    l++;
                }
                ans = Math.Max(ans, r - l);
                set.Add(a[r]);
            }
            Console.WriteLine(ans + 1);
        }
    }
}
