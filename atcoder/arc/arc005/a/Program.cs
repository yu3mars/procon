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
            string[] w = Console.ReadLine().Replace(".", "").Split(' ');
            string[] t = new string[] { "TAKAHASHIKUN", "Takahashikun", "takahashikun" };
            int ans = 0;
            for (int i = 0; i < w.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    if (w[i] == t[j])
                    {
                        ans++;
                        break;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
