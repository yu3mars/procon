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
            List<int> upa = new List<int>();
            List<int> upb = new List<int>();
            List<int> downa = new List<int>();
            List<int> downb = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = ab[0];
                int b = ab[1];
                if (a<b)
                {
                    downa.Add(a);
                    downb.Add(b);
                }
                else
                {
                    upa.Add(a);
                    upb.Add(b);
                }
            }
            var down = downa.Zip(downb, (x, y) => new { x, y }).ToArray();
            Array.Sort(down, (a, b) => {
                if (a.x != b.x) return a.x.CompareTo(b.x);
                return -a.y.CompareTo(b.y);
            });
            var up = upa.Zip(upb, (x, y) => new { x, y }).ToArray();
            Array.Sort(up, (a, b) => {
                return (a.x - a.y).CompareTo(b.x - b.y);
            });
            int t = 0;
            int ans = 0;
            foreach (var p in down)
            {
                t += p.x;
                ans = Math.Max(ans, t);
                t -= p.y;
            }
            foreach (var p in up)
            {
                t += p.x;
                ans = Math.Max(ans, t);
                t -= p.y;
            }
            Console.WriteLine(ans);
        }
    }
}
