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
            for (int i = 0; i < n; i++)
            {
                switch (a[i]%6)
                {
                    case 1:
                        break;
                    case 2:
                        ans++;
                        break;
                    case 3:
                        break;
                    case 0:
                        ans += 3;
                        break;
                    default:
                        ans += (a[i] % 6 - 3);
                        break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
