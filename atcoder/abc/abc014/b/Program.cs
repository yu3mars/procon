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
            int[] nx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = nx[1];
            int ans = 0;
            for (int i = 0; i < nx[0]; i++)
            {
                if((x>>i)%2>0)
                {
                    ans += a[i];
                }
            }
            Console.WriteLine(ans);
        }
    }
}
