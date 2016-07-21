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
            int[] lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] l = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lls = new int[41];
            int[] rls = new int[41];
            for (int i = 0; i < l.Length; i++)
            {
                lls[l[i]]++;
            }
            for (int i = 0; i < r.Length; i++)
            {
                rls[r[i]]++;
            }
            int ans = 0;
            for (int i = 0; i < lls.Length; i++)
            {
                ans += Math.Min(lls[i], rls[i]);
            }
            Console.WriteLine(ans);
        }
    }
}
