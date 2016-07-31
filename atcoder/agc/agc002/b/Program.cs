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
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            bool[] red = new bool[n];
            int[] box = new int[n];
            for (int i = 0; i < n; i++)
            {
                box[i] = 1;
            }
            red[0] = true;
            for (int i = 0; i < m; i++)
            {
                int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = xy[0] - 1;
                int y = xy[1] - 1;
                if(red[x])
                {
                    red[y] = true;
                }
                box[x]--;
                box[y]++;
                if(box[x]<1)
                {
                    red[x] = false;
                }
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (red[i]) ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
