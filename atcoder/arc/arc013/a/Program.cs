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
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ans = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if(i!=j&&j!=k &&k!=i)
                        {
                            int tmp = ((n[0] / p[i]) * (n[1] / p[j]) * (n[2] / p[k]));
                            ans = Math.Max(ans, tmp);
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
