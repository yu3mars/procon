using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kn = Console.ReadLine().Split(' ');
            int k = int.Parse(kn[0]);

            if (k > 3) return;// to delete

            int n = int.Parse(kn[1]);
            string[] ans = new string[k];
            string[][] vw = new string[n][];
            for (int i = 0; i < n; i++)
            {
                vw[i] = Console.ReadLine().Split(' ');
                for (int j = 0; j < vw[i][0].Length; j++)
                {
                    ans[vw[i][0][j] - '0' - 1] = vw[i][1][j].ToString();
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
