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
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                dic.Add(a[i], i + 1);
            }
            Array.Sort(a);
            Array.Reverse(a);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dic[a[i]]);
            }
        }
    }
}
