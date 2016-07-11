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
            int[] path =Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] map = new int[n];
            for (int i = 0; i < n; i++)
            {
                map[i] = int.MaxValue / 3;
            }
            Queue<int> loc = new Queue<int>();
            Queue<int> val = new Queue<int>();
            loc.Enqueue(0);
            val.Enqueue(0);
            while(loc.Count>0)
            {
                int nowloc = loc.Dequeue();
                int nowval = val.Dequeue();
                if(nowval < map[nowloc])
                {
                    map[nowloc] = nowval;
                    if(nowloc>0)//mae
                    {
                        loc.Enqueue(nowloc - 1);
                        val.Enqueue(nowval + 1);
                    }
                    if (nowloc < n - 1)//mae
                    {
                        loc.Enqueue(nowloc + 1);
                        val.Enqueue(nowval + 1);
                    }
                    loc.Enqueue(path[nowloc] - 1);
                    val.Enqueue(nowval + 1);
                }
            }

            string ans = String.Join(" ", map);
            Console.WriteLine(ans);
        }
    }
}
