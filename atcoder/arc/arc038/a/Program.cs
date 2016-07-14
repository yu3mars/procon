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
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(a);
            Array.Reverse(a);
            int ans = 0;
            for (int i = 0; i < a.Length; i+=2)
            {
                ans += a[i];
            }
            Console.WriteLine(ans);
        }
    }
}
