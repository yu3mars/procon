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
            int[] mnn = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = mnn[0];
            int n = mnn[1];
            int x = mnn[2];
            int stock = x;
            int ans = x;
            while(m <= stock)
            {
                int consume = stock - stock % m;
                int made = stock / m * n;
                ans += made;
                stock = stock - consume + made;
            }
            Console.WriteLine(ans);
        }
    }
}
